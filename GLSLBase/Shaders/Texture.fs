#version 450

layout(location=0) out vec4 FragColor;	// 사용자가 정의한 출력 값

uniform sampler2D u_TexSampler;

in vec2 v_TexPos;

const float PI = 3.141592;

vec4 P1()
{
	vec2 newTex = v_TexPos;
	newTex.y = abs(newTex.y - 0.5) * 2.0;
	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 P2()
{
	vec2 newTex = v_TexPos;
	newTex.x = fract(newTex.x * 3.0);
	newTex.y = floor(v_TexPos.x * 3.0) / 3.0 + newTex.y / 3.0;
	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 P3()
{
	vec2 newTex = v_TexPos;
	newTex.x = fract(newTex.x * 3.0);
	newTex.y = -ceil(v_TexPos.x * 3.0) / 3.0 + (newTex.y / 3.0);
	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 P4()
{
	vec2 newTex = v_TexPos;
	newTex.x = ceil(v_TexPos.y * 3.0) - newTex.x / 3;
	newTex.y = fract(v_TexPos.x * 3.0) + newTex.y;
	vec4 returnColor = texture(u_TexSampler, newTex);

	return returnColor;
}

void main()
{
	//FragColor = texture(u_TexSampler, v_TexPos);
	FragColor = P4();
}