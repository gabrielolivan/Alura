<?php

namespace App\Services;

use App\Models\{ Serie, Temporada, Episodio};
use Illuminate\Support\Facades\DB;

class RemovedorDeSerie
{
    public function removedorSerie(int $serieId) : string
    {
        $nomeSerie = '';
        DB::transaction(function () use ($serieId, &$nomeSerie) {
            $serie = Serie::find($serieId);
            $nomeSerie = $serie->nome;
            $this->removeTemporadas($serie);
            $serie->delete();
        });

        return $nomeSerie;
    }

    public function removeTemporadas(Serie $serie): void
    {
        $serie->temporadas->each(function(Temporada $temporada){
            $this->removeEpisodio($temporada);
            $temporada->delete();
        });
    }

    public function removeEpisodio(Temporada $temporada): void
    {
        $temporada->episodios()->each(function(Episodio $episodio){
            $episodio->delete();
        });
    }

}