@echo off 

REM zeker weten dat de goede branch gepakt wordt
git checkout feature/%1

REM git files aan commit toevoegen
git add .

REM changes lokaal committen
git commit -m"feature/%1"

REM controleren op conflicten met de origin develop
git rebase develop

REM feature branch pushen naar origin feature branch
git push --set-upstream origin feature/%1


