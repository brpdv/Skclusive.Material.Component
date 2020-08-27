using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skclusive.Material.Theme
{
    public partial class PaletteConfig
    {
        [JsonPropertyName("action")]
        public PaletteAction Action { get; set; }

        [JsonPropertyName("background")]
        public PaletteBackground Background { get; set; }

        [JsonPropertyName("common")]
        public PaletteCommon Common { get; set; }

        [JsonPropertyName("contrastThreshold")]
        public decimal? ContrastThreshold { get; set; }

        [JsonPropertyName("divider")]
        public string Divider { get; set; }

        [JsonPropertyName("error")]
        public PaletteColorConfig Error { get; set; }

        [JsonPropertyName("getContrastText")]
        public Dictionary<string, object> GetContrastText { get; set; }

        [JsonPropertyName("grey")]
        public PaletteShade Grey { get; set; }

        [JsonPropertyName("primary")]
        public PaletteColorConfig Primary { get; set; }

        [JsonPropertyName("secondary")]
        public PaletteColorConfig Secondary { get; set; }

        [JsonPropertyName("text")]
        public PaletteText Text { get; set; }

        [JsonPropertyName("tonalOffset")]
        public decimal? TonalOffset { get; set; }

        [JsonPropertyName("type")]
        public PaletteType? Type { get; set; }

        [JsonPropertyName("custom")]
        public PaletteCustom Custom { get; set; }
    }
}