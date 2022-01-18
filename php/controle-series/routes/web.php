<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SeriesController;
use App\Http\Controllers\TemporadasController;

// Route::get('/series', [SeriesController::class, 'index']);
Route::get('/series', 'SeriesController@index')->name('listar_series');

Route::get('/series/criar', [SeriesController::class, 'create'])->name('form_criar_serie');
Route::post('/series/criar', [SeriesController::class, 'store']);
Route::delete('/series/{id}', [SeriesController::class, 'destroy']);
Route::get('/series/{serieId}/temporadas', [TemporadasController::class, 'index']);