from django.db import models

class Fotografia(models.Model):
    nome = models.CharField(max_length=100, blank=False, null=False)
    legenda = models.CharField(max_length=150, blank=False, null=False)
    descricao = models.TextField(null=False, blank=False)
    foto = models.CharField(max_length=100, blank=False, null=False)

    def __str__(self):
        return f'Fotografia [nome = {self.nome}]'
