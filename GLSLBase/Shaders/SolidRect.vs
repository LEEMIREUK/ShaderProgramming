#version 450

in vec3 a_Position;	// float 3개
//in vec3 a_Position1;	// float 3개, 총 6개 floats

//uniform float u_Scale;
//uniform vec3 u_Position;

void main()
{
	//vec3 temp = a_Position;
	//temp = temp + u_Position;
	gl_Position = vec4(a_Position, 1);	// OpenGL 고유의 출력 값
}