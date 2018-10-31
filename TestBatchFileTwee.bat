@echo off 

REM zeker weten dat de goede branch gepakt wordt
git checkout feature/%1

REM git files aan commit toevoegen
git add .

REM changes lokaal committen
git commit -m"feature/%1"


