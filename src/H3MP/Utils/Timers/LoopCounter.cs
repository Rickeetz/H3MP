namespace H3MP.Utils
{
	public class LoopCounter
	{
		public uint Count { get; private set; }

		public uint Duration { get; }

		public LoopCounter(uint duration)
		{
			Duration = duration;

			Reset();
		}

		public void Reset()
		{
			Count = Duration;
		}

		public bool TryReset()
		{
			if (--Count > 0)
			{
				return false;
			}

			Reset();
			return true;
		}
	}
}
