<?php

use App\Http\Controllers\EntrarController;
use App\Http\Controllers\EpisodiosController;
use App\Http\Controllers\RegistroController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SeriesController;
use App\Http\Controllers\TemporadasController;
use Illuminate\Support\Facades\Auth;

// Route::get('/series', [SeriesController::class, 'index']);
Route::get('/series', 'SeriesController@index')->name('listar_series');

Route::get('/series/criar', [SeriesController::class, 'create'])->name('form_criar_serie')->middleware('autenticador');
Route::post('/series/criar', [SeriesController::class, 'store'])->middleware('autenticador');
Route::delete('/series/{id}', [SeriesController::class, 'destroy'])->middleware('autenticador');
Route::get('/series/{serieId}/temporadas', [TemporadasController::class, 'index']);
Route::post('/series/{id}/editaNome', [SeriesController::class, 'editaNome'])->middleware('autenticador');

Route::get('/temporadas/{temporada}/episodios', [EpisodiosController::class, 'index']);
Route::post('/temporadas/{temporada}/episodios/assistir', [EpisodiosController::class, 'assistir'])->middleware('autenticador');

//login meu
Route::get('/entrar', [EntrarController::class, 'index']);
Route::post('/entrar', [EntrarController::class, 'entrar']);
Route::get('/sair', function(){
    Auth::logout();
    return redirect('/entrar');
});

//register meu
Route::get('/registrar', [RegistroController::class, 'create']);
Route::post('/registrar', [RegistroController::class, 'store']);



//login laravel
Auth::routes();
Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');
