from django.shortcuts import render, redirect
from usuarios.forms import LoginForms, CadastroForms
from django.contrib.auth.models import User
from django.contrib import auth
from django.contrib import messages

def login(request): 
    form = LoginForms()

    if request.method == 'POST':
        form = LoginForms(request.POST)

        if form.is_valid():
            nome= form['nome_login'].value()
            senha= form['senha'].value()

        usuario = auth.authenticate(
            request,
            username= nome,
            password= senha
        )

        if usuario is not None:
            messages.success(request, f'Usuário {nome} logado com sucesso.')
            auth.login(request, usuario)
            return redirect('index')
        else:
            messages.error(request, 'Usuário ou senha inválidos.')
            return redirect('login')

    return render(request, 'usuarios/login.html', {'form': form})

def cadastro(request):
    form = CadastroForms()

    if request.method == 'POST':
        form = CadastroForms(request.POST)

        if form.is_valid():
            
            nome = form['nome_cadastro'].value()
            email = form['email'].value()
            senha = form['senha1'].value()

            if User.objects.filter(username=nome).exists():
                messages.error(request, 'Nome de usuário já existente.')
                return redirect('cadastro')
            
            usuario = User.objects.create_user(
                username=nome,
                email=email,
                password=senha
            )
            usuario.save()
            messages.success(request, 'Usuário cadastrado com sucesso.')
            return redirect('login')
        elif 'email' in form.errors:
            messages.error(request, 'Email inválido, é necessário seguir a estrutura do exemplo.')
            return redirect('cadastro')

    return render(request, 'usuarios/cadastro.html', {'form': form})

def logout(request):
    auth.logout(request)
    messages.success(request, 'Logout efetuado com sucesso.')
    return redirect('login') 