#version 400 core

in vec4 ourColor;
in vec2 ourTextureCoordinate; 

out vec4 FragColor;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float opacity;

void main()
{
	FragColor = mix(texture(texture1, ourTextureCoordinate), texture(texture2, ourTextureCoordinate), opacity);
}