namespace PatternsPractice.AdapterPattern;

public class SonyTvUsingNewTurnOnAdapter : INewSamsungTurnOn
{
    private readonly LegacySonyClass _sonyTV;

    public SonyTvUsingNewTurnOnAdapter(LegacySonyClass sonyTV)
    {
        _sonyTV = sonyTV;
    }

    public void TurnOn()
    {
        _sonyTV.PowerOn();
    }
}