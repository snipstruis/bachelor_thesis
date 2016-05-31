C=xelatex --interaction=nonstopmode --halt-on-error -output-directory=build

all: build/cover.pdf *.tex
	$C main
	biber main --output-directory build
	$C main 
	$C main 

build/cover.pdf: cover.tex
	$C cover.tex
