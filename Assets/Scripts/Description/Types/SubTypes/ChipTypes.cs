namespace DLS.Description
{
	public enum ChipType
	{
		Custom,

		// ---- Basic Chips ----
		Nand,
		TriStateBuffer,
		Clock,
		Pulse,

		// ---- Memory ----
		dev_Ram_8Bit,
		Rom_256x2x8,
		Rom_256x16,
		Rom_256x32,

		// ---- Displays ----
		SevenSegmentDisplay,
		DisplayRGB,
		DisplayDot,
		DisplayLED,
		DisplayRGBLED,
		DisplayAscii_8Bit,

		// ---- Merge / Split ----
		Merge_1To4Bit,
		Merge_1To8Bit,
		Merge_4To8Bit,
		Merge_1To16Bit,
		Merge_4To16Bit,
		Merge_8To16Bit,
		Split_4To1Bit,
		Split_8To4Bit,
		Split_8To1Bit,
		Split_16To1Bit,
		Split_16To4Bit,
		Split_16To8Bit,

		// ---- In / Out Pins ----
		In_1Bit,
		In_4Bit,
		In_8Bit,
		In_16Bit,
		Out_1Bit,
		Out_4Bit,
		Out_8Bit,
		Out_16Bit,

		Key,

		// ---- Buses ----
		Bus_1Bit,
		BusTerminus_1Bit,
		Bus_4Bit,
		BusTerminus_4Bit,
		Bus_8Bit,
		BusTerminus_8Bit,
		Bus_16Bit,
		BusTerminus_16Bit,
		
		// ---- Audio ----
		Buzzer,

		// ---- Ports ----
		Port_In,
		Port_Out

	}
}