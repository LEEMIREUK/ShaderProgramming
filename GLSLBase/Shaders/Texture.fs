#version 450

layout(location=0) out vec4 FragColor;	// 사용자가 정의한 출력 값

uniform sampler2D u_TexSampler;

in vec2 v_TexPos;

void main()
{
	//FragColor = vec4(1);
	FragColor = vec4(v_TexPos, 0, 1);
	//FragColor = texture(u_TexSampler, v_TexPos);
}