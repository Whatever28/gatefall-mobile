public class BombHazard : Hazard
{
    protected override void OnHitPlayer(Health p)
    {
        p.TakeDamage(2);
        GetComponent<Bomb>().Explode();
    }
}
