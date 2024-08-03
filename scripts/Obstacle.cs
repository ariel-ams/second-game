using Godot;
using System;

public partial class Obstacle : StaticBody2D
{
	[Export]
	private float tiempoTranscurrido = 0f;
	[Export]
	private float amplitud = 5f; // Ajusta esto para cambiar qué tan arriba/abajo se mueve
	[Export]
	private float frecuencia = 1f; // Ajusta esto para cambiar la velocidad del movimiento

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		RandomNumberGenerator rng = new RandomNumberGenerator();
        rng.Randomize();
		tiempoTranscurrido = rng.RandfRange(0, 2 * Mathf.Pi);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		tiempoTranscurrido += (float)delta;
    
		float desplazamientoY = amplitud * Mathf.Sin(frecuencia * tiempoTranscurrido * (2 * Mathf.Pi));
    
		MoveLocalY(desplazamientoY);

	}

}
