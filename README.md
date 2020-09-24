# AsteroidDestroyer

# Task
1. The map is endless. - DONE
2. The camera follows you around. - DONE
3. Your ship on collision with an asteroid should be destroyed. - DONE
	a. UI text appear “You lose” - DONE
	b. Button “Restart” appear that restarts the game. - DONE
	c. All simulation is held while the game is lost. - DONE
4. You steer your ship with W or Arrow up - Forward; A, D or Arrow left, right - Rotation. Your ship shoots automatically every 0.5 seconds. - DONE
5. Your bullets are destroyed after they existed for 3 seconds or after a collision with the asteroid. - DONE
6. After the bullet destroys the asteroid, a score is increased and Text on UI with score changes. - DONE
7. Asteroids are destroyed after a collision with other asteroids or with the bullet. - DONE
	7.1. Destroyed asteroids are re-spawned after 1 second at random position that is outside of the player view frustum (asteroid can spawn on another asteroid causing immediate collision) - DONE
8. Asteroids should spawn on the grid 160 x 160 units, one asteroid in the center of one grid tile.
9. On the map, you should generate 25 600 asteroids.
10. Ship spawns at the center of the map. - DONE
11. All asteroids must have random speed larger than 0 and random direction. - DONE
12. Make sure every asteroid speed and direction is persistent every game. - DONE
13. All Asteroids should be always simulated (flying and colliding) even if they are not visible. - DONE