<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SeriesController;

// Route::get('/series', [SeriesController::class, 'index']);
Route::get('/series', 'SeriesController@index');

Route::get('/series/criar', [SeriesController::class, 'create']);
Route::post('/series/criar', [SeriesController::class, 'store']);
