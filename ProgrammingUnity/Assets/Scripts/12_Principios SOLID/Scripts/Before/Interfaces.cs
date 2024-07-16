namespace Course.SOLID.Before
{
    public interface IInteract
    {
        void Interact();
    }

    public interface IDamage
    {
        void Damage(int value);
    }

    public interface IHeal
    {
        void Heal(int value);
    }
}