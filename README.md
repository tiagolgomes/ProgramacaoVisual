# ProgramacaoVisual
Repositório da Disciplina

...

git clone https://github.com/tiagolgomes/ProgramacaoVisual

cd ProgramacaoVisual/

mkdir source
cd source

mkdir ProgramacaoVisual
cd ProgramacaoVisual

dotnet new sln

mkdir WebMvc
cd WebMvc

dotnet new mvc

cd ..

dotnet sln ProgramacaoVisual.sln add WebMvc/WebMvc.csproj
...

...

echo
git config --global user.email "tiagolacerdagomes@gmail.com"
git config --global user.name "Tiago de Lacerda Gomes"

git add *

gitcommit -m "Initial commit"
git push origin master
...