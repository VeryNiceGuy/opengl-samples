#version 450 core
precision highp float;

out vec4 fragColor;
in vec4 color;

void main()
{ 		
  fragColor = color;  	
}