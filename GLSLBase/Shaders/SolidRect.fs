#version 450

layout(location=0) out vec4 FragColor;	// 사용자가 정의한 출력 값

//uniform vec4 u_Color;

in vec4 v_Color;

void main()
{
	//FragColor = vec4(0.5,0.2,1,1);
	FragColor = v_Color;
}