#version 450

in vec3 a_Position;	// float 3��
in vec3 a_Position1;	// float 3��, �� 6�� floats

void main()
{
	gl_Position = vec4(a_Position, 1);	// OpenGL ������ ��� ��
}
