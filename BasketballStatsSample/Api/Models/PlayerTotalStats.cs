using Newtonsoft.Json;

namespace Api.Models
{
	public class PlayerTotalStatsCollection
	{
		[JsonProperty("meta")]
		public Metadata Metadata { get; set; }
		[JsonProperty("stats")]
		public PlayerTotalStats[] Stats { get; set; }
	}

	public class Metadata
	{
		[JsonProperty("Season")]
		public short Year { get; set; }
		[JsonProperty("Team")]
		public string Team { get; set; }
	}

    public class PlayerTotalStats
    {
		[JsonProperty("Name")]
	    public string PlayerName { get; set; }
	    public byte Age { get; set; }
		[JsonProperty("G")]
	    public byte GamesPlayed { get; set; }
	    [JsonProperty("GS")]
		public byte GamesStarted { get; set; }
	    [JsonProperty("MP")]
		public short MinutesPlayed { get; set; }
	    [JsonProperty("FG")]
		public short FieldGoalsMade { get; set; }
	    [JsonProperty("FGA")]
		public short FieldGoalAttempted { get; set; }
	    [JsonProperty("FG%")]
		public decimal FieldGoalPct { get; set; }
	    [JsonProperty("3P")]
		public short ThreePointersMade { get; set; }
	    [JsonProperty("3PA")]
		public short ThreePointersAttempted { get; set; }
	    [JsonProperty("3P%")]
		public decimal ThreePointerPct { get; set; }
	    [JsonProperty("2P")]
		public short TwoPointersMade { get; set; }
	    [JsonProperty("2PA")]
		public short TwoPointersAttempted { get; set; }
	    [JsonProperty("2P%")]
		public decimal TwoPointerPct { get; set; }
	    [JsonProperty("eFG%")]
		public decimal EffectiveFieldGoalPct { get; set; }
	    [JsonProperty("FT")]
		public short FreeThrowsMade { get; set; }
	    [JsonProperty("FTA")]
		public short FreeThrowsAttempted { get; set; }
	    [JsonProperty("FT%")]
		public decimal FreeThrowPct { get; set; }
	    [JsonProperty("ORB")]
		public short OffensiveRebounds { get; set; }
	    [JsonProperty("DRB")]
		public short DefensiveRebounds { get; set; }
	    [JsonProperty("TRB")]
		public short TotalRebounds { get; set; }
	    [JsonProperty("AST")]
		public short Assists { get; set; }
	    [JsonProperty("STL")]
		public short Steals { get; set; }
	    [JsonProperty("BLK")]
		public short Blocks { get; set; }
	    [JsonProperty("TOV")]
		public short Turnovers { get; set; }
	    [JsonProperty("PF")]
		public short PersonalFouls { get; set; }
	    [JsonProperty("PTS")]
		public short Points { get; set; }
    }
}
