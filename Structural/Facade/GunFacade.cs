namespace Facade;

public class GunFacade
{
    private readonly ParticleSystem _particleSystem;
    private readonly AnimationSystem _animationSystem;
    private readonly AmmoSystem _ammoSystem;
    private readonly RecoilSystem _recoilSystem;
    private readonly SoundSystem _soundSystem;

    public GunFacade()
    {
        _particleSystem = new ParticleSystem();
        _animationSystem = new AnimationSystem();
        _ammoSystem = new AmmoSystem();
        _recoilSystem = new RecoilSystem();
        _soundSystem = new SoundSystem();
    }

    public void Shoot()
    {
        _animationSystem.Play("射击动画");
        _ammoSystem.ConsumeBullet();
        _recoilSystem.ApplyRecoil();
        _soundSystem.PlaySound("枪声");
        _particleSystem.SpawnParticle("枪口闪光");
    }
}