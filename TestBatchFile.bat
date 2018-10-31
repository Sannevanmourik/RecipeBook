@echo off 

REM checken welke branches er zijn
REM git branch

REM develop lokaal aanmaken
REM git checkout -b develop
git checkout develop

REM checken dat de develop lokaal is aangemaakt
git branch

REM zorgen dat develop lokaal up to date is met develop origin
git pull origin develop

REM feature branch aanmaken
git checkout -b feature/%1

