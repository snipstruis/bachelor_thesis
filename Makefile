C=xelatex --interaction=nonstopmode --halt-on-error

all: cover.pdf *.tex
	$C main
	biber   main 
	$C main 
	$C main 

cover.pdf: cover.tex
	$C cover.tex
