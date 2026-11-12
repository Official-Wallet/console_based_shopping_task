using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public class Products_list
    {
        
        public Product[] products = {
            
            new Product(
                1,
                "iPhone 15 Pro",
                "Apple smartphone featuring a 6.1-inch Super Retina XDR display, A17 Pro chip, titanium design and 48MP main camera.",
                1250000,
                5,
                new string[] { "smartphone", "apple", "electronics", "mobile" }
            ),

            new Product(
                2,
                "Samsung Galaxy S24 Ultra",
                "Samsung flagship smartphone featuring a 6.8-inch Dynamic AMOLED display, 200MP camera, S Pen and Snapdragon 8 Gen 3 processor.",
                1850000,
                5,
                new string[] { "smartphone", "samsung", "electronics", "mobile" }
            ),

            new Product(
                3,
                "Sony WH-1000XM5",
                "Wireless over-ear headphones with industry-leading noise cancellation, 30-hour battery life and high-resolution audio support.",
                620000,
                5,
                new string[] { "headphones", "sony", "audio", "electronics" }
            ),

            new Product(
                4,
                "MacBook Air M3",
                "Apple laptop powered by the M3 chip, featuring a 13.6-inch Liquid Retina display, 16GB unified memory and 512GB SSD storage.",
                2150000,
                5,
                new string[] { "laptop", "apple", "computers", "electronics" }
            ),

            new Product(
                5,
                "PlayStation 5 Slim",
                "Sony gaming console featuring ultra-high-speed SSD storage, ray tracing support, 4K gaming and DualSense wireless controller.",
                950000,
                4,
                new string[] { "gaming", "playstation", "sony", "electronics" }
            ),

            new Product(
                6,
                "JBL Flip 6",
                "Portable Bluetooth speaker with IP67 water and dust resistance, powerful stereo sound and up to 12 hours of battery life.",
                185000,
                4,
                new string[] { "speaker", "jbl", "audio", "electronics" }
            ),

            new Product(
                7,
                "Apple Watch Series 9",
                "Smartwatch featuring an Always-On Retina display, health and fitness tracking, temperature sensing and water resistance.",
                480000,
                4,
                new string[] { "smartwatch", "apple", "wearables", "electronics" }
            ),

            new Product(
                8,
                "Logitech MX Master 3S",
                "Wireless ergonomic mouse featuring an 8K DPI sensor, quiet clicks, MagSpeed scrolling and multi-device connectivity.",
                210000,
                5,
                new string[] { "mouse", "logitech", "computer-accessories", "electronics" }
            ),

            new Product(
                9,
                "Anker 737 Power Bank",
                "Portable 24000mAh power bank with 140W USB-C output, smart digital display and fast charging support for compatible devices.",
                195000,
                4,
                new string[] { "power-bank", "anker", "charging", "electronics" }
            ),

            new Product(
                10,
                "Dell UltraSharp U2723QE",
                "27-inch 4K UHD professional monitor featuring IPS Black technology, USB-C connectivity and an integrated USB hub.",
                1150000,
                5,
                new string[] { "monitor", "dell", "computer-accessories", "electronics" }
            ),

            new Product(
                11,
                "Nike Air Max 270",
                "Lifestyle running shoes featuring Max Air cushioning, breathable mesh upper and lightweight foam midsole.",
                185000,
                5,
                new string[] { "fashion", "footwear", "nike", "sportswear" }
            ),

            new Product(
                12,
                "Samsung 55-inch QLED TV",
                "55-inch 4K QLED smart television featuring HDR support, built-in streaming applications and voice control.",
                1450000,
                4,
                new string[] { "electronics", "television", "samsung", "home-entertainment" }
            ),

            new Product(
                13,
                "Nescafe Gold Coffee",
                "Premium instant coffee made from carefully selected Arabica and Robusta coffee beans.",
                18500,
                4,
                new string[] { "groceries", "beverages", "coffee", "food" }
            ),

            new Product(
                14,
                "Adidas Essentials Hoodie",
                "Comfortable cotton-blend hoodie featuring a regular fit, adjustable drawstring hood and front kangaroo pocket.",
                65000,
                4,
                new string[] { "fashion", "clothing", "adidas", "sportswear" }
            ),

            new Product(
                15,
                "IKEA LACK Coffee Table",
                "Minimalist coffee table featuring a lightweight construction, clean design and durable laminated surface.",
                125000,
                4,
                new string[] { "furniture", "home-decor", "living-room", "ikea" }
            ),

            new Product(
                16,
                "CeraVe Moisturizing Cream",
                "Daily moisturizing cream formulated with ceramides and hyaluronic acid to help maintain the skin's protective barrier.",
                32000,
                5,
                new string[] { "beauty", "skincare", "moisturizer", "personal-care" }
            ),

            new Product(
                17,
                "Wilson Evolution Basketball",
                "Indoor basketball featuring a microfiber composite leather cover, cushioned feel and deep channel construction.",
                95000,
                5,
                new string[] { "sports", "basketball", "wilson", "fitness" }
            ),

            new Product(
                18,
                "The Psychology of Money",
                "A personal finance book exploring how human behaviour, decision-making and emotions influence financial success.",
                18000,
                5,
                new string[] { "books", "education", "finance", "personal-development" }
            ),

            new Product(
                19,
                "Dyson V8 Vacuum Cleaner",
                "Cordless vacuum cleaner featuring powerful suction, multiple cleaning attachments and a hygienic bin-emptying mechanism.",
                850000,
                4,
                new string[] { "home-appliances", "cleaning", "dyson", "electronics" }
            ),

            new Product(
                20,
                "Zara Leather Crossbody Bag",
                "Elegant everyday crossbody bag featuring a structured silhouette, adjustable shoulder strap and zip closure.",
                95000,
                4,
                new string[] { "fashion", "bags", "accessories", "zara" }
            ),

            new Product(
                21,
                "Organic Honey 500g",
                "Natural honey suitable for everyday cooking, baking and use as a sweetener in beverages.",
                12500,
                4,
                new string[] { "groceries", "food", "organic", "sweeteners" }
            ),

            new Product(
                22,
                "Philips Air Fryer",
                "Digital air fryer featuring adjustable temperature controls, multiple cooking presets and rapid hot-air circulation.",
                285000,
                4,
                new string[] { "kitchen-appliances", "cooking", "philips", "home-appliances" }
            ),

            new Product(
                23,
                "Puma Running Shorts",
                "Lightweight athletic shorts featuring breathable fabric, an elastic waistband and moisture-wicking technology.",
                42000,
                4,
                new string[] { "fashion", "sportswear", "puma", "clothing" }
            ),

            new Product(
                24,
                "L'Oréal Paris Revitalift Serum",
                "Facial serum formulated with hyaluronic acid to help hydrate skin and improve its appearance.",
                28000,
                4,
                new string[] { "beauty", "skincare", "serum", "loreal" }
            ),

            new Product(
                25,
                "Stanley Quencher H2.0 Tumbler",
                "Insulated stainless-steel tumbler featuring a reusable straw, ergonomic handle and double-wall vacuum insulation.",
                85000,
                5,
                new string[] { "lifestyle", "drinkware", "kitchen", "accessories" }
            ),

            new Product(
                26,
                "HP LaserJet Pro M404dn",
                "Monochrome laser printer designed for office environments, featuring automatic duplex printing and wired network connectivity.",
                780000,
                4,
                new string[] { "electronics", "printers", "office-equipment", "hp" }
            ),

            new Product(
                27,
                "Coleman Camping Tent",
                "Four-person outdoor camping tent featuring weather-resistant fabric, ventilation panels and a straightforward setup system.",
                195000,
                4,
                new string[] { "outdoors", "camping", "sports", "travel" }
            ),

            new Product(
                28,
                "Levi's 501 Original Jeans",
                "Classic straight-fit denim jeans featuring a button fly, five-pocket design and traditional denim construction.",
                110000,
                5,
                new string[] { "fashion", "clothing", "denim", "levis" }
            ),

            new Product(
                29,
                "Oral-B Pro 3 Electric Toothbrush",
                "Rechargeable electric toothbrush featuring a pressure sensor, multiple cleaning modes and a two-minute brushing timer.",
                145000,
                4,
                new string[] { "personal-care", "oral-care", "hygiene", "electronics" }
            ),

            new Product(
                30,
                "Pampers Premium Care Diapers",
                "Disposable baby diapers featuring an absorbent core, soft materials and a moisture indicator for everyday baby care.",
                38000,
                5,
                new string[] { "baby-products", "parenting", "hygiene", "diapers" }
            ),

            new Product(
                31,
                "Canon EOS R50",
                "Mirrorless digital camera featuring a 24.2MP APS-C sensor, 4K video recording and advanced autofocus capabilities.",
                1250000,
                5,
                new string[] { "photography", "cameras", "canon", "electronics" }
            ),

            new Product(
                32,
                "Gucci GG Marmont Wallet",
                "Compact designer wallet featuring signature quilted leather, a double G emblem and multiple card compartments.",
                420000,
                5,
                new string[] { "fashion", "luxury", "wallets", "accessories" }
            ),

            new Product(
                33,
                "Bose SoundLink Flex",
                "Portable Bluetooth speaker featuring waterproof construction, balanced audio performance and a rechargeable battery.",
                280000,
                4,
                new string[] { "audio", "speakers", "bose", "electronics" }
            ),

            new Product(
                34,
                "KitchenAid Artisan Stand Mixer",
                "Kitchen stand mixer featuring a tilt-head design, multiple speed settings and interchangeable attachments for baking.",
                1150000,
                5,
                new string[] { "kitchen", "baking", "appliances", "home" }
            ),

            new Product(
                35,
                "New Balance 574 Sneakers",
                "Classic lifestyle sneakers featuring suede and mesh construction, ENCAP cushioning and a durable rubber outsole.",
                145000,
                4,
                new string[] { "footwear", "fashion", "sneakers", "new-balance" }
            ),

            new Product(
                36,
                "Kindle Paperwhite",
                "Water-resistant e-reader featuring a high-resolution glare-free display, adjustable warm light and extended battery life.",
                350000,
                5,
                new string[] { "electronics", "reading", "amazon", "e-readers" }
            ),

            new Product(
                37,
                "Dove Deep Moisture Body Wash",
                "Moisturizing body wash formulated with gentle cleansers and skin-conditioning ingredients for everyday bathing.",
                9500,
                4,
                new string[] { "beauty", "bath", "personal-care", "skincare" }
            ),

            new Product(
                38,
                "Samsonite Winfield 3 DLX Suitcase",
                "Hard-shell travel suitcase featuring a scratch-resistant exterior, multidirectional spinner wheels and an expandable interior.",
                385000,
                4,
                new string[] { "travel", "luggage", "suitcases", "accessories" }
            ),

            new Product(
                39,
                "Yamaha F310 Acoustic Guitar",
                "Steel-string acoustic guitar featuring a spruce top, comfortable neck profile and warm balanced sound.",
                285000,
                5,
                new string[] { "music", "instruments", "guitar", "yamaha" }
            ),

            new Product(
                40,
                "Olay Regenerist Micro-Sculpting Cream",
                "Facial moisturizing cream formulated with niacinamide and peptides to improve hydration and skin appearance.",
                38000,
                4,
                new string[] { "beauty", "skincare", "moisturizer", "cosmetics" }
            ),

            new Product(
                41,
                "Crocs Classic Clog",
                "Lightweight casual clogs featuring Croslite material, ventilation ports and an adjustable heel strap.",
                55000,
                4,
                new string[] { "footwear", "fashion", "casual", "crocs" }
            ),

            new Product(
                42,
                "Instant Pot Duo 7-in-1",
                "Multifunctional electric pressure cooker supporting pressure cooking, slow cooking, steaming, sautéing and rice preparation.",
                245000,
                5,
                new string[] { "kitchen", "cooking", "appliances", "home" }
            ),

            new Product(
                43,
                "Ralph Lauren Oxford Shirt",
                "Classic men's button-down shirt featuring cotton construction, a button-down collar and embroidered chest logo.",
                125000,
                4,
                new string[] { "fashion", "menswear", "clothing", "shirts" }
            ),

            new Product(
                44,
                "Xiaomi Robot Vacuum S10",
                "Automated robotic vacuum featuring laser navigation, scheduled cleaning, obstacle detection and smart home connectivity.",
                580000,
                4,
                new string[] { "electronics", "cleaning", "smart-home", "appliances" }
            ),

            new Product(
                45,
                "Fjallraven Kanken Backpack",
                "Durable everyday backpack featuring a spacious main compartment, front zip pocket and water-resistant fabric.",
                145000,
                5,
                new string[] { "bags", "fashion", "backpacks", "travel" }
            ),

            new Product(
                46,
                "The Lean Startup",
                "Business book explaining validated learning, continuous experimentation and efficient product development methodologies.",
                22000,
                5,
                new string[] { "books", "business", "entrepreneurship", "education" }
            ),

            new Product(
                47,
                "La Roche-Posay Anthelios SPF 50",
                "Broad-spectrum sunscreen formulated for daily facial protection against UVA and UVB radiation.",
                42000,
                5,
                new string[] { "beauty", "skincare", "sunscreen", "personal-care" }
            ),

            new Product(
                48,
                "DeWalt 20V Cordless Drill",
                "Cordless power drill featuring variable-speed control, a rechargeable battery system and an ergonomic grip for drilling and fastening tasks.",
                420000,
                5,
                new string[] { "tools", "hardware", "construction", "dewalt" }
            ),

            new Product(
                49,
                "Herschel Little America Backpack",
                "Outdoor-inspired backpack featuring a drawstring closure, padded laptop sleeve and magnetic strap fastenings.",
                175000,
                4,
                new string[] { "fashion", "bags", "backpacks", "travel" }
            ),

            new Product(
                50,
                "Nutella Hazelnut Spread",
                "Sweet hazelnut and cocoa spread suitable for breakfast, baking and dessert preparation.",
                14500,
                5,
                new string[] { "groceries", "food", "spreads", "desserts" }
            ),

            new Product(
                51,
                "Garmin Forerunner 265",
                "GPS running watch featuring an AMOLED display, advanced training metrics, recovery insights and multisport tracking.",
                850000,
                5,
                new string[] { "electronics", "fitness", "wearables", "sports" }
            ),

            new Product(
                52,
                "Bissell SpotClean Pro",
                "Portable carpet and upholstery cleaner designed to remove stains using water, cleaning solution and powerful suction.",
                390000,
                4,
                new string[] { "home-appliances", "cleaning", "carpet-care", "bissell" }
            ),

            new Product(
                53,
                "Calvin Klein Eternity Eau de Parfum",
                "Floral fragrance featuring a balanced blend of fresh, aromatic and woody notes for everyday wear.",
                95000,
                4,
                new string[] { "beauty", "fragrance", "perfume", "personal-care" }
            ),

            new Product(
                54,
                "Under Armour HeatGear Compression Shirt",
                "Lightweight athletic compression shirt featuring moisture-wicking fabric and stretch construction for training sessions.",
                48000,
                4,
                new string[] { "sportswear", "fitness", "clothing", "under-armour" }
            ),

            new Product(
                55,
                "LEGO Technic McLaren Formula 1 Car",
                "Detailed construction building set featuring realistic mechanical components, steering functionality and a Formula 1-inspired design.",
                185000,
                5,
                new string[] { "toys", "lego", "collectibles", "construction-sets" }
            ),

            new Product(
                56,
                "Casio G-Shock GA-2100",
                "Shock-resistant analog-digital wristwatch featuring a carbon-reinforced case, stopwatch and world-time functions.",
                145000,
                5,
                new string[] { "fashion", "watches", "accessories", "casio" }
            ),

            new Product(
                57,
                "Tefal Ingenio Cookware Set",
                "Non-stick cookware collection featuring detachable handles, stackable pans and versatile cooking surfaces.",
                325000,
                4,
                new string[] { "kitchen", "cookware", "home", "cooking" }
            ),

            new Product(
                58,
                "Porsche Design Sunglasses",
                "Premium sunglasses featuring lightweight construction, UV-protective lenses and a contemporary frame design.",
                285000,
                4,
                new string[] { "fashion", "eyewear", "accessories", "luxury" }
            ),

            new Product(
                59,
                "Brita Marella Water Filter Jug",
                "Household water filter jug featuring replaceable filtration cartridges, a convenient pouring lid and a compact refrigerator-friendly design.",
                68000,
                4,
                new string[] { "home", "kitchen", "water-filtration", "household" }
            ),

            new Product(
                60,
                "Fender Player Stratocaster",
                "Electric guitar featuring an alder body, three single-coil pickups and a versatile five-way pickup selector.",
                1850000,
                5,
                new string[] { "music", "instruments", "guitar", "fender" }
            ),

            new Product(
                61,
                "The Ordinary Niacinamide 10% + Zinc 1%",
                "Water-based facial serum formulated with niacinamide and zinc to support skin appearance and oil balance.",
                18000,
                4,
                new string[] { "beauty", "skincare", "serum", "cosmetics" }
            ),

            new Product(
                62,
                "Babolat Pure Drive Tennis Racket",
                "Performance tennis racket featuring a graphite frame, aerodynamic construction and responsive string-bed design.",
                380000,
                5,
                new string[] { "sports", "tennis", "rackets", "fitness" }
            ),

            new Product(
                63,
                "Nespresso Vertuo Pop",
                "Compact coffee machine featuring capsule-based brewing technology and automatic beverage-size recognition.",
                420000,
                4,
                new string[] { "kitchen", "coffee", "appliances", "beverages" }
            ),

            new Product(
                64,
                "Tommy Hilfiger Leather Belt",
                "Classic leather belt featuring a polished metal buckle and a versatile design suitable for formal and casual outfits.",
                58000,
                4,
                new string[] { "fashion", "accessories", "belts", "menswear" }
            ),

            new Product(
                65,
                "Bosch UniversalAquatak Pressure Washer",
                "Electric pressure washer designed for outdoor cleaning, featuring adjustable spray settings and interchangeable nozzles.",
                350000,
                4,
                new string[] { "home", "gardening", "cleaning", "power-tools" }
            ),

            new Product(
                66,
                "Jo Malone English Pear & Freesia Cologne",
                "Elegant fragrance featuring fresh pear, white freesia and warm woody base notes.",
                185000,
                5,
                new string[] { "beauty", "fragrance", "luxury", "perfume" }
            ),

            new Product(
                67,
                "Catan Board Game",
                "Strategy board game involving resource collection, trading, settlement building and competitive territory development.",
                68000,
                5,
                new string[] { "games", "board-games", "entertainment", "family" }
            ),

            new Product(
                68,
                "Ray-Ban Aviator Classic",
                "Iconic aviator sunglasses featuring a lightweight metal frame and UV-protective lenses.",
                165000,
                5,
                new string[] { "fashion", "eyewear", "sunglasses", "accessories" }
            ),

            new Product(
                69,
                "Moleskine Classic Notebook",
                "Hardcover notebook featuring acid-free paper, an elastic closure, rounded corners and an expandable rear pocket.",
                28000,
                4,
                new string[] { "stationery", "office-supplies", "writing", "notebooks" }
            ),

            new Product(
                70,
                "Karcher K4 Power Control",
                "High-pressure washer designed for cleaning patios, vehicles and outdoor surfaces with adjustable water pressure.",
                580000,
                5,
                new string[] { "electronics", "cleaning", "outdoor-equipment", "household" }
            ),

            new Product(
                71,
                "Lacoste Classic Polo Shirt",
                "Cotton piqué polo shirt featuring a ribbed collar, short sleeves and embroidered crocodile logo.",
                92000,
                4,
                new string[] { "fashion", "clothing", "polo-shirts", "menswear" }
            ),

            new Product(
                72,
                "Weber Original Kettle Charcoal Grill",
                "Outdoor charcoal barbecue grill featuring a porcelain-enameled bowl, adjustable dampers and a removable ash catcher.",
                450000,
                5,
                new string[] { "outdoors", "grilling", "garden", "cooking" }
            ),

            new Product(
                73,
                "Hugo Boss Bottled Eau de Toilette",
                "Men's fragrance featuring fresh apple notes, warm spices and a woody base for everyday use.",
                115000,
                4,
                new string[] { "beauty", "fragrance", "mens-grooming", "perfume" }
            ),

            new Product(
                74,
                "Trek Marlin 5 Mountain Bike",
                "Entry-level mountain bike featuring an aluminum frame, front suspension fork and reliable disc braking system.",
                1250000,
                4,
                new string[] { "sports", "cycling", "outdoors", "bicycles" }
            ),

            new Product(
                75,
                "Philips Sonicare ProtectiveClean 6100",
                "Rechargeable electric toothbrush featuring pressure sensing, multiple brushing modes and a built-in timer.",
                220000,
                5,
                new string[] { "personal-care", "oral-care", "hygiene", "electronics" }
            ),

            new Product(
                76,
                "IKEA MALM Bed Frame",
                "Minimalist bedroom bed frame featuring a clean-lined design, durable construction and coordinated headboard.",
                480000,
                4,
                new string[] { "furniture", "bedroom", "home-decor", "ikea" }
            ),

            new Product(
                77,
                "Lindt Excellence Dark Chocolate",
                "Premium dark chocolate bar featuring a rich cocoa flavour and smooth texture.",
                9500,
                5,
                new string[] { "groceries", "food", "chocolate", "confectionery" }
            ),

            new Product(
                78,
                "Eastpak Padded Pak'r Backpack",
                "Everyday backpack featuring a spacious main compartment, padded back panel and front zippered pocket.",
                68000,
                4,
                new string[] { "fashion", "bags", "backpacks", "school-supplies" }
            ),

            new Product(
                79,
                "Makita 18V Impact Driver",
                "Cordless impact driver featuring variable-speed control, compact construction and high torque for fastening applications.",
                365000,
                5,
                new string[] { "tools", "hardware", "construction", "makita" }
            ),

            new Product(
                80,
                "The Alchemist",
                "Fiction novel following a young shepherd's journey of self-discovery, purpose and personal transformation.",
                16000,
                5,
                new string[] { "books", "fiction", "literature", "personal-development" }
            ),

            new Product(
                81,
                "Osprey Farpoint 40 Travel Backpack",
                "Travel backpack featuring a spacious main compartment, adjustable harness system and lockable zipper sliders.",
                320000,
                5,
                new string[] { "travel", "outdoors", "backpacks", "luggage" }
            ),

            new Product(
                82,
                "Breville Barista Express",
                "Espresso machine featuring an integrated conical burr grinder, adjustable grind settings and manual milk frothing.",
                1850000,
                5,
                new string[] { "kitchen", "coffee", "appliances", "breville" }
            ),

            new Product(
                83,
                "Clinique Moisture Surge 100H",
                "Lightweight facial moisturizer formulated to provide long-lasting hydration and support the skin moisture barrier.",
                55000,
                4,
                new string[] { "beauty", "skincare", "moisturizer", "cosmetics" }
            ),

            new Product(
                84,
                "Callaway Strata Golf Club Set",
                "Beginner-friendly golf club collection featuring a driver, fairway wood, hybrid, irons, putter and golf bag.",
                1250000,
                5,
                new string[] { "sports", "golf", "outdoors", "fitness" }
            ),

            new Product(
                85,
                "Polaroid Now Generation 2",
                "Instant analog camera featuring autofocus, built-in flash, self-timer and compatibility with Polaroid i-Type film.",
                380000,
                4,
                new string[] { "photography", "cameras", "electronics", "polaroid" }
            ),

            new Product(
                86,
                "Aesop Resurrection Aromatique Hand Wash",
                "Premium hand wash formulated with botanical extracts and aromatic ingredients for everyday hand cleansing.",
                42000,
                5,
                new string[] { "beauty", "personal-care", "hand-care", "luxury" }
            ),

            new Product(
                87,
                "Pottery Barn Belgian Flax Linen Duvet Cover",
                "Premium bedding accessory made from linen fabric, featuring a relaxed texture and breathable construction.",
                285000,
                4,
                new string[] { "home", "bedding", "bedroom", "home-decor" }
            ),

            new Product(
                88,
                "Hot Wheels Premium Car Collection",
                "Die-cast collectible vehicle featuring detailed exterior styling, realistic wheels and a display-ready finish.",
                18000,
                5,
                new string[] { "toys", "collectibles", "vehicles", "hobbies" }
            ),

            new Product(
                89,
                "Logitech Brio 4K Webcam",
                "Ultra HD webcam featuring 4K video capture, automatic light correction, autofocus and integrated microphones.",
                320000,
                4,
                new string[] { "electronics", "computer-accessories", "webcams", "office-equipment" }
            ),

            new Product(
                90,
                "Seiko 5 Sports Automatic Watch",
                "Automatic mechanical wristwatch featuring a stainless-steel case, day-date display and water-resistant construction.",
                280000,
                5,
                new string[] { "fashion", "watches", "accessories", "seiko" }
            ),

            new Product(
                91,
                "Blueair Blue Pure 311i Max",
                "Smart air purifier featuring multi-stage particle filtration, adjustable fan speeds and app-based monitoring.",
                650000,
                4,
                new string[] { "home-appliances", "air-purification", "health-and-wellness", "electronics" }
            ),

            new Product(
                92,
                "Yeti Rambler 30 oz Tumbler",
                "Insulated stainless-steel drinkware featuring double-wall vacuum insulation and a durable kitchen-grade construction.",
                75000,
                5,
                new string[] { "lifestyle", "drinkware", "outdoors", "accessories" }
            ),

            new Product(
                93,
                "Estée Lauder Double Wear Foundation",
                "Long-wearing liquid foundation offering buildable coverage and an oil-controlling finish in multiple shades.",
                68000,
                5,
                new string[] { "beauty", "makeup", "cosmetics", "foundation" }
            ),

            new Product(
                94,
                "Razer DeathAdder V3",
                "Ergonomic wired gaming mouse featuring a high-precision optical sensor, programmable buttons and lightweight construction.",
                185000,
                5,
                new string[] { "gaming", "computer-accessories", "electronics", "razer" }
            ),

            new Product(
                95,
                "Crate & Barrel Marble Serving Board",
                "Decorative natural marble serving board suitable for presenting cheese, appetizers and small desserts.",
                85000,
                4,
                new string[] { "home", "kitchen", "dining", "home-decor" }
            ),

            new Product(
                96,
                "Wilson Pro Staff Tennis Bag",
                "Professional tennis equipment bag featuring multiple racket compartments, accessory pockets and adjustable shoulder straps.",
                145000,
                4,
                new string[] { "sports", "tennis", "bags", "sports-accessories" }
            ),

            new Product(
                97,
                "Dyson Airwrap Multi-Styler",
                "Hair styling system featuring multiple attachments designed for curling, shaping, smoothing and drying hair using controlled airflow.",
                1650000,
                5,
                new string[] { "beauty", "hair-care", "styling", "electronics" }
            ),

            new Product(
                98,
                "National Geographic World Atlas",
                "Illustrated geographical reference book featuring detailed maps, country information and geographical insights.",
                35000,
                4,
                new string[] { "books", "education", "geography", "reference" }
            ),

            new Product(
                99,
                "Victorinox Swiss Army Huntsman",
                "Multifunctional pocket tool featuring a collection of practical implements for outdoor activities and everyday utility.",
                65000,
                5,
                new string[] { "outdoors", "tools", "camping", "accessories" }
            ),

            new Product(
                100,
                "Ninja Foodi MAX Dual Zone Air Fryer",
                "Dual-compartment air fryer featuring independent cooking zones, synchronized cooking functions and adjustable temperature controls.",
                520000,
                5,
                new string[] { "kitchen", "cooking", "home-appliances", "electronics" }
            )

        };

    }
    
}