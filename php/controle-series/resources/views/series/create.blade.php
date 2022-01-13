@extends('layout')

@section('cabecalho')
Adicionar Séries
@endsection


@section('conteudo')
    <form method="post">
        @csrf
        <div class="mb-3">
            <label for="nome" class="form-label">Nome</label>
            <input type="text" class="form-control" name="nome" id="nome">
        </div>

        <button type="submit" class="btn btn-primary">Adicionar</button>
    </form>
@endsection