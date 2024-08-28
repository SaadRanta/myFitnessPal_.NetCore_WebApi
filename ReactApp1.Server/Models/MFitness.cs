using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace WebApi_Respository_Pattren.Models
{
    public class MFitness
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("NDB_No")]
        [JsonPropertyName("NDB_No")]
        public int NdbNo { get; set; }

        [BsonElement("Shrt_Desc")]
        [JsonPropertyName("Shrt_Desc")]
        public string ShrtDesc { get; set; }

        [BsonElement("Water_(g)")]
        [JsonPropertyName("Water_(g)")]
        public double? Water { get; set; }

        [BsonElement("Energ_Kcal")]
        [JsonPropertyName("Energ_Kcal")]
        public double? EnergKcal { get; set; }

        [BsonElement("Protein_(g)")]
        [JsonPropertyName("Protein_(g)")]
        public double? Protein { get; set; }

        [BsonElement("Lipid_Tot_(g)")]
        [JsonPropertyName("Lipid_Tot_(g)")]
        public double? LipidTot { get; set; }

        [BsonElement("Ash_(g)")]
        [JsonPropertyName("Ash_(g)")]
        public double? Ash { get; set; }

        [BsonElement("Carbohydrt_(g)")]
        [JsonPropertyName("Carbohydrt_(g)")]
        public double? Carbohydrt { get; set; }

        [BsonElement("Fiber_TD_(g)")]
        [JsonPropertyName("Fiber_TD_(g)")]
        public double? FiberTD { get; set; }

        [BsonElement("Sugar_Tot_(g)")]
        [JsonPropertyName("Sugar_Tot_(g)")]
        public double? SugarTot { get; set; }

        [BsonElement("Calcium_(mg)")]
        [JsonPropertyName("Calcium_(mg)")]
        public double? Calcium { get; set; }

        [BsonElement("Iron_(mg)")]
        [JsonPropertyName("Iron_(mg)")]
        public double? Iron { get; set; }

        [BsonElement("Magnesium_(mg)")]
        [JsonPropertyName("Magnesium_(mg)")]
        public double? Magnesium { get; set; }

        [BsonElement("Phosphorus_(mg)")]
        [JsonPropertyName("Phosphorus_(mg)")]
        public double? Phosphorus { get; set; }

        [BsonElement("Potassium_(mg)")]
        [JsonPropertyName("Potassium_(mg)")]
        public double? Potassium { get; set; }

        [BsonElement("Sodium_(mg)")]
        [JsonPropertyName("Sodium_(mg)")]
        public double? Sodium { get; set; }

        [BsonElement("Zinc_(mg)")]
        [JsonPropertyName("Zinc_(mg)")]
        public double? Zinc { get; set; }

        [BsonElement("Copper_mg)")]
        [JsonPropertyName("Copper_mg)")]
        public double? Copper { get; set; }

        [BsonElement("Manganese_(mg)")]
        [JsonPropertyName("Manganese_(mg)")]
        public double? Manganese { get; set; }

        [BsonElement("Selenium_(µg)")]
        [JsonPropertyName("Selenium_(µg)")]
        public double? Selenium { get; set; }

        [BsonElement("Vit_C_(mg)")]
        [JsonPropertyName("Vit_C_(mg)")]
        public double? VitC { get; set; }

        [BsonElement("Thiamin_(mg)")]
        [JsonPropertyName("Thiamin_(mg)")]
        public double? Thiamin { get; set; }

        [BsonElement("Riboflavin_(mg)")]
        [JsonPropertyName("Riboflavin_(mg)")]
        public double? Riboflavin { get; set; }

        [BsonElement("Niacin_(mg)")]
        [JsonPropertyName("Niacin_(mg)")]
        public double? Niacin { get; set; }

        [BsonElement("Panto_Acid_mg)")]
        [JsonPropertyName("Panto_Acid_mg)")]
        public double? PantoAcid { get; set; }

        [BsonElement("Vit_B6_(mg)")]
        [JsonPropertyName("Vit_B6_(mg)")]
        public double? VitB6 { get; set; }

        [BsonElement("Folate_Tot_(µg)")]
        [JsonPropertyName("Folate_Tot_(µg)")]
        public double? FolateTot { get; set; }

        [BsonElement("Folic_Acid_(µg)")]
        [JsonPropertyName("Folic_Acid_(µg)")]
        public double? FolicAcid { get; set; }

        [BsonElement("Food_Folate_(µg)")]
        [JsonPropertyName("Food_Folate_(µg)")]
        public double? FoodFolate { get; set; }

        [BsonElement("Folate_DFE_(µg)")]
        [JsonPropertyName("Folate_DFE_(µg)")]
        public double? FolateDFE { get; set; }

        [BsonElement("Choline_Tot_ (mg)")]
        [JsonPropertyName("Choline_Tot_ (mg)")]
        public double? CholineTot { get; set; }

        [BsonElement("Vit_B12_(µg)")]
        [JsonPropertyName("Vit_B12_(µg)")]
        public double? VitB12 { get; set; }

        [BsonElement("Vit_A_IU")]
        [JsonPropertyName("Vit_A_IU")]
        public double? VitA_IU { get; set; }

        [BsonElement("Vit_A_RAE")]
        [JsonPropertyName("Vit_A_RAE")]
        public double? VitA_RAE { get; set; }

        [BsonElement("Retinol_(µg)")]
        [JsonPropertyName("Retinol_(µg)")]
        public double? Retinol { get; set; }

        [BsonElement("Alpha_Carot_(µg)")]
        [JsonPropertyName("Alpha_Carot_(µg)")]
        public double? AlphaCarot { get; set; }

        [BsonElement("Beta_Carot_(µg)")]
        [JsonPropertyName("Beta_Carot_(µg)")]
        public double? BetaCarot { get; set; }

        [BsonElement("Beta_Crypt_(µg)")]
        [JsonPropertyName("Beta_Crypt_(µg)")]
        public double? BetaCrypt { get; set; }

        [BsonElement("Lycopene_(µg)")]
        [JsonPropertyName("Lycopene_(µg)")]
        public double? Lycopene { get; set; }

        [BsonElement("Lut+Zea_ (µg)")]
        [JsonPropertyName("Lut+Zea_ (µg)")]
        public double? LutZea { get; set; }

        [BsonElement("Vit_E_(mg)")]
        [JsonPropertyName("Vit_E_(mg)")]
        public double? VitE { get; set; }

        [BsonElement("Vit_D_µg")]
        [JsonPropertyName("Vit_D_µg ")]
        public double? VitD { get; set; }

        [BsonElement("Vit_D_IU")]
        [JsonPropertyName("Vit_D_IU")]
        public double? VitD_IU { get; set; }

        [BsonElement("Vit_K_(µg)")]
        [JsonPropertyName("Vit_K_(µg)")]
        public double? VitK { get; set; }

        [BsonElement("FA_Sat_(g)")]
        [JsonPropertyName("FA_Sat_(g)")]
        public double? FA_Sat { get; set; }

        [BsonElement("FA_Mono_(g)")]
        [JsonPropertyName("FA_Mono_(g)")]
        public double? FA_Mono { get; set; }

        [BsonElement("FA_Poly_(g)")]
        [JsonPropertyName("FA_Poly_(g)")]
        public double? FA_Poly { get; set; }

        [BsonElement("Cholestrl_(mg)")]
        [JsonPropertyName("Cholestrl_(mg)")]
        public double? Cholestrl { get; set; }

        [BsonElement("GmWt_1")]
        [JsonPropertyName("GmWt_1")]
        public double? GmWt1 { get; set; }

        [BsonElement("GmWt_Desc1")]
        [JsonPropertyName("GmWt_Desc1")]
        public string GmWtDesc1 { get; set; }

        [BsonElement("GmWt_2")]
        [JsonPropertyName("GmWt_2")]
        public double? GmWt2 { get; set; }

        [BsonElement("GmWt_Desc2")]
        [JsonPropertyName("GmWt_Desc2")]
        public string GmWtDesc2 { get; set; }

        [BsonElement("Refuse_Pct")]
        [JsonPropertyName("Refuse_Pct")]
        public double? RefusePct { get; set; }
    }
}
