#version 400 core

in vec4 ourColor;
in vec2 ourTextureCoordinate; 

out vec4 FragColor;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
	FragColor = mix(texture(texture1, ourTextureCoordinate), 
		texture(texture2, vec2(1.0f - ourTextureCoordinate.x, ourTextureCoordinate.y)), 
		0.2f
	);
}