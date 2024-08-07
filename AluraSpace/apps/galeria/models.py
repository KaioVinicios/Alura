from django.db import models
from datetime import datetime
from django.contrib.auth.models import User

OPCOES_CATEGORIA = [
    ('NEBULOSA', 'Nebulosa'),
    ('GALÁXIA', 'Galáxia'),
    ('ESTRELA', 'Estrela'),
    ('PLANETA', 'Planeta')
]

class Fotografia(models.Model):
    nome = models.CharField(max_length=100, blank=False, null=False)
    legenda = models.CharField(max_length=150, blank=False, null=False)
    descricao = models.TextField(null=False, blank=False)
    categoria = models.CharField(max_length=100, choices=OPCOES_CATEGORIA, default='')
    foto = models.ImageField(upload_to='fotos/%Y/%m/%d/', blank=True)
    data_fotografia = models.DateTimeField(default=datetime.now, blank= False)
    publicada = models.BooleanField(default= True)
    usuario = models.ForeignKey(
        to= User,
        on_delete= models.SET_NULL,
        null= True,
        blank= False,
        related_name= 'user',
    )

    def __str__(self):
        return self.nome
