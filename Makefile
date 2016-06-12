C=xelatex --interaction=nonstopmode --halt-on-error -output-directory=build

all: *.tex
	rm build/*
	$C cover.tex
	$C main
	biber main --output-directory build
	$C main 
	$C main 
