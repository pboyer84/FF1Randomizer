using System.ComponentModel;

namespace FF1Lib
{
	public enum HeirloomBearers
	{
		[Description("Not an heirloom")]
		None,
		[Description("Of the Humans")]
		Human,
		[Description("Of the Elves")]
		Elf,
		[Description("Of the Dwarves")]
		Dwarf,
		[Description("Of the Dragons")]
		Dragon,
		[Description("Random")]
		Random
	}
}
