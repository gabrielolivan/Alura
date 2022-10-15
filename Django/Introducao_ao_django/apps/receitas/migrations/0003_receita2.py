# Generated by Django 3.2.7 on 2021-09-28 14:25

import datetime
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('receitas', '0002_auto_20210928_1124'),
    ]

    operations = [
        migrations.CreateModel(
            name='Receita2',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nome_receita', models.CharField(max_length=200)),
                ('ingredientes', models.TextField()),
                ('modo_preparo', models.TextField()),
                ('tempo_preparo', models.IntegerField()),
                ('rendimento', models.CharField(max_length=100)),
                ('categoria', models.CharField(max_length=100)),
                ('date_receita', models.DateTimeField(blank=True, default=datetime.datetime.now)),
            ],
        ),
    ]