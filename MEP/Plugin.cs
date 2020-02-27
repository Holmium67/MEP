using EXILED;

namespace MEP
{
	public class Minimal : Plugin
	{
		public EventHandlers EventHandlers { get; private set; }

		public override void OnEnable()
		{
			EventHandlers = new EventHandlers(this);
			Events.RoundStartEvent += EventHandlers.OnRoundStart;
			Events.RoundEndEvent += EventHandlers.OnRoundEnd;
		}

		public override void OnDisable()
		{
			Events.RoundStartEvent -= EventHandlers.OnRoundStart;
			Events.RoundEndEvent -= EventHandlers.OnRoundEnd;
			EventHandlers = null;
		}

		public override void OnReload()
		{

		}

		public override string getName { get; } = "";
	}
}
