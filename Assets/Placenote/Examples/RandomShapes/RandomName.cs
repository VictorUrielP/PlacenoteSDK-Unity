﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomName
{

    public static string Get()
    {
        string adjective = Adjectives[Random.Range(0, Adjectives.Length)];
        string animal = Animals[Random.Range(0, Animals.Length)];

        return adjective + " " + animal;
    }

    public static readonly string[] Adjectives = {
        "Able",
        "Abnormal",
        "Above",
        "Absent",
        "Absolute",
        "Abstract",
        "Absurd",
        "Academic",
        "Acceptable",
        "Accessible",
        "Accounting",
        "Accurate",
        "Accused",
        "Active",
        "Actual",
        "Acute",
        "Added",
        "Additional",
        "Adequate",
        "Adjacent",
        "Administrative",
        "Adult",
        "Advanced",
        "Adverse",
        "Advisory",
        "Aesthetic",
        "Afraid",
        "Aggregate",
        "Aggressive",
        "Agreed",
        "Agricultural",
        "Alert",
        "Alien",
        "Alive",
        "Alleged",
        "Allied",
        "Alone",
        "Alright",
        "Alternative",
        "Amateur",
        "Amazing",
        "Ambiguous",
        "Ambitious",
        "Ample",
        "Ancient",
        "Angry",
        "Annual",
        "Anonymous",
        "Anxious",
        "Appalling",
        "Apparent",
        "Applicable",
        "Applied",
        "Appointed",
        "Appropriate",
        "Approved",
        "Arbitrary",
        "Archaeological",
        "Architectural",
        "Armed",
        "Artificial",
        "Artistic",
        "Ashamed",
        "Asleep",
        "Assistant",
        "Associated",
        "Astonishing",
        "Atomic",
        "Attempted",
        "Attractive",
        "Automatic",
        "Autonomous",
        "Available",
        "Average",
        "Awake",
        "Aware",
        "Awful",
        "Awkward",
        "Back",
        "Bad",
        "Balanced",
        "Bare",
        "Basic",
        "Beautiful",
        "Beneficial",
        "Big",
        "Binding",
        "Biological",
        "Bitter",
        "Bizarre",
        "Black",
        "Blank",
        "Bleak",
        "Blind",
        "Blonde",
        "Bloody",
        "Blue",
        "Bodily",
        "Bold",
        "Bored",
        "Boring",
        "Bottom",
        "Bourgeois",
        "Brave",
        "Brief",
        "Bright",
        "Brilliant",
        "Broad",
        "Broken",
        "Brown",
        "Bureaucratic",
        "Burning",
        "Busy",
        "Calm",
        "Capable",
        "Capital",
        "Careful",
        "Casual",
        "Causal",
        "Cautious",
        "Central",
        "Certain",
        "Changing",
        "Characteristic",
        "Charming",
        "Cheap",
        "Cheerful",
        "Chemical",
        "Chief",
        "Chosen",
        "Chronic",
        "Circular",
        "Civic",
        "Civil",
        "Civilian",
        "Classic",
        "Classical",
        "Clean",
        "Clear",
        "Clerical",
        "Clever",
        "Clinical",
        "Close",
        "Closed",
        "Cooperative",
        "Coastal",
        "Cognitive",
        "Coherent",
        "Cold",
        "Collective",
        "Colonial",
        "Color-blind",
        "Colorful",
        "Combined",
        "Comfortable",
        "Coming",
        "Commercial",
        "Common",
        "Communist",
        "Comparable",
        "Comparative",
        "Compatible",
        "Competent",
        "Competitive",
        "Complementary",
        "Complete",
        "Complex",
        "Complicated",
        "Comprehensive",
        "Compulsory",
        "Conceptual",
        "Concerned",
        "Concrete",
        "Confident",
        "Confidential",
        "Conscious",
        "Conservative",
        "Considerable",
        "Consistent",
        "Constant",
        "Constitutional",
        "Constructive",
        "Contemporary",
        "Content",
        "Continental",
        "Continued",
        "Continuing",
        "Continuous",
        "Contractual",
        "Contrary",
        "Controlled",
        "Controversial",
        "Convenient",
        "Conventional",
        "Convincing",
        "Cool",
        "Corporate",
        "Correct",
        "Corresponding",
        "Costly",
        "Crazy",
        "Creative",
        "Criminal",
        "Critical",
        "Crucial",
        "Crude",
        "Cruel",
        "Cultural",
        "Curious",
        "Current",
        "Daily",
        "Damaging",
        "Damp",
        "Dangerous",
        "Dark",
        "Dead",
        "Deadly",
        "Deaf",
        "Dear",
        "Decent",
        "Decisive",
        "Decorative",
        "Deep",
        "Defensive",
        "Definite",
        "Deliberate",
        "Delicate",
        "Delicious",
        "Delighted",
        "Delightful",
        "Democratic",
        "Dense",
        "Departmental",
        "Dependent",
        "Depending",
        "Depressed",
        "Desirable",
        "Desired",
        "Desperate",
        "Detailed",
        "Determined",
        "Developed",
        "Developing",
        "Devoted",
        "Different",
        "Differential",
        "Difficult",
        "Digital",
        "Diplomatic",
        "Direct",
        "Dirty",
        "Disabled",
        "Disastrous",
        "Disciplinary",
        "Distant",
        "Distinct",
        "Distinctive",
        "Distinguished",
        "Distributed",
        "Diverse",
        "Divine",
        "Domestic",
        "Dominant",
        "Double",
        "Doubtful",
        "Dramatic",
        "Dreadful",
        "Driving",
        "Drunk",
        "Dry",
        "Dual",
        "Due",
        "Dull",
        "Dynamic",
        "Eager",
        "Early",
        "Eastern",
        "Easy",
        "Economic",
        "Educational",
        "Effective",
        "Efficient",
        "Elaborate",
        "Elderly",
        "Elected",
        "Electoral",
        "Electric",
        "Electrical",
        "Electronic",
        "Elegant",
        "Eligible",
        "Embarrassed",
        "Embarrassing",
        "Emotional",
        "Empirical",
        "Empty",
        "Encouraging",
        "Endless",
        "Enhanced",
        "Enjoyable",
        "Enormous",
        "Enthusiastic",
        "Entire",
        "Environmental",
        "Equal",
        "Equivalent",
        "Essential",
        "Established",
        "Estimated",
        "Eternal",
        "Ethical",
        "Ethnic",
        "Eventual",
        "Everyday",
        "Evident",
        "Evil",
        "Evolutionary",
        "Exact",
        "Excellent",
        "Exceptional",
        "Excess",
        "Excessive",
        "Excited",
        "Exciting",
        "Exclusive",
        "Executive",
        "Existing",
        "Exotic",
        "Expected",
        "Expensive",
        "Experienced",
        "Experimental",
        "Expert",
        "Explicit",
        "Express",
        "Extended",
        "Extensive",
        "External",
        "Extra",
        "Extraordinary",
        "Extreme",
        "Faint",
        "Fair",
        "Faithful",
        "False",
        "Familiar",
        "Famous",
        "Fantastic",
        "Far",
        "Fascinating",
        "Fashionable",
        "Fast",
        "Fat",
        "Fatal",
        "Favorable",
        "Favorite",
        "Feasible",
        "Federal",
        "Fellow",
        "Female",
        "Feminine",
        "Fierce",
        "Final",
        "Financial",
        "Fine",
        "Finished",
        "Firm",
        "First",
        "Fiscal",
        "Fit",
        "Fixed",
        "Flat",
        "Flexible",
        "Following",
        "Fond",
        "Foolish",
        "Foreign",
        "Formal",
        "Formidable",
        "Forthcoming",
        "Fortunate",
        "Forward",
        "Fragile",
        "Free",
        "Frequent",
        "Fresh",
        "Friendly",
        "Frightened",
        "Front",
        "Frozen",
        "Futile",
        "Full",
        "Full-time",
        "Fun",
        "Functional",
        "Fundamental",
        "Funny",
        "Furious",
        "Future",
        "Gastric",
        "Gay",
        "General",
        "Generous",
        "Genetic",
        "Gentle",
        "Genuine",
        "Geographical",
        "Geological",
        "Giant",
        "Given",
        "Glad",
        "Global",
        "Glorious",
        "Gold",
        "Golden",
        "Good",
        "Gothic",
        "Gradual",
        "Grammatical",
        "Grand",
        "Grateful",
        "Grave",
        "Great",
        "Green",
        "Gray",
        "Grim",
        "Gross",
        "Growing",
        "Guilty",
        "Handicapped",
        "Handsome",
        "Handy",
        "Happy",
        "Hard",
        "Harmful",
        "Harsh",
        "Head",
        "Healthy",
        "Heavy",
        "Helpful",
        "Helpless",
        "Hidden",
        "High",
        "Historic",
        "Historical",
        "Holy",
        "Homeless",
        "Homogenous",
        "Honest",
        "Honorable",
        "Horizontal",
        "Horrible",
        "Hostile",
        "Hot",
        "Huge",
        "Human",
        "Humble",
        "Hungry",
        "Ideal",
        "Identical",
        "Ideological",
        "Ill",
        "Illegal",
        "Imaginative",
        "Immediate",
        "Immense",
        "Imminent",
        "Immune",
        "Imperial",
        "Implicit",
        "Important",
        "Impossible",
        "Impressive",
        "Improved",
        "Inadequate",
        "Inappropriate",
        "Incapable",
        "Inclined",
        "Increased",
        "Increasing",
        "Incredible",
        "Independent",
        "Indigenous",
        "Indirect",
        "Individual",
        "Indoor",
        "Industrial",
        "Inevitable",
        "Infinite",
        "Influential",
        "Informal",
        "Inherent",
        "Initial",
        "Injured",
        "Inland",
        "Inner",
        "Innocent",
        "Innovative",
        "Instant",
        "Institutional",
        "Instrumental",
        "Insufficient",
        "Intact",
        "Integral",
        "Integrated",
        "Intellectual",
        "Intelligent",
        "Intense",
        "Intensive",
        "Intent",
        "Interactive",
        "Interested",
        "Interesting",
        "Interim",
        "Interior",
        "Intermediate",
        "Internal",
        "International",
        "Intimate",
        "Invaluable",
        "Invisible",
        "Involved",
        "Irrelevant",
        "Irrespective",
        "Isolated",
        "Jealous",
        "Joint",
        "Judicial",
        "Junior",
        "Just",
        "Justified",
        "Keen",
        "Key",
        "Kind",
        "Known",
        "Labor",
        "Lacking",
        "Large",
        "Large-scale",
        "Last",
        "Late",
        "Latin",
        "Lay",
        "Lazy",
        "Leading",
        "Left",
        "Legal",
        "Legislative",
        "Legitimate",
        "Lengthy",
        "Lesser",
        "Level",
        "Lexical",
        "Liable",
        "Liberal",
        "Light",
        "Like",
        "Likely",
        "Limited",
        "Linear",
        "Linguistic",
        "Liquid",
        "Literary",
        "Little",
        "Live",
        "Lively",
        "Living",
        "Local",
        "Logical",
        "Lone",
        "Lonely",
        "Long",
        "Long-term",
        "Loose",
        "Lost",
        "Loud",
        "Lovely",
        "Low",
        "Loyal",
        "Lucky",
        "Luxury",
        "Mad",
        "Magic",
        "Magical",
        "Magnetic",
        "Magnificent",
        "Main",
        "Major",
        "Male",
        "Managerial",
        "Managing",
        "Mandatory",
        "Manual",
        "Manufacturing",
        "Marginal",
        "Marine",
        "Marked",
        "Married",
        "Marvelous",
        "Mass",
        "Massive",
        "Material",
        "Mathematical",
        "Mature",
        "Maximum",
        "Mean",
        "Meaningful",
        "Mechanical",
        "Medical",
        "Medieval",
        "Medium",
        "Memorable",
        "Mental",
        "Mere",
        "Metropolitan",
        "Mid",
        "Middle",
        "Middle-class",
        "Mighty",
        "Mild",
        "Military",
        "Minimal",
        "Minimum",
        "Ministerial",
        "Minor",
        "Minute",
        "Miserable",
        "Misleading",
        "Missing",
        "Mixed",
        "Mobile",
        "Moderate",
        "Modern",
        "Modest",
        "Molecular",
        "Monetary",
        "Monthly",
        "Moral",
        "Moving",
        "Multiple",
        "Municipal",
        "Musical",
        "Mutual",
        "Mysterious",
        "Naked",
        "Narrow",
        "Nasty",
        "National",
        "Native",
        "Natural",
        "Naval",
        "Near",
        "Nearby",
        "Neat",
        "Necessary",
        "Negative",
        "Neighboring",
        "Nervous",
        "Net",
        "Neutral",
        "New",
        "Nice",
        "Noble",
        "Noisy",
        "Nominal",
        "Normal",
        "Northern",
        "Notable",
        "Noticeable",
        "Notorious",
        "Novel",
        "Nuclear",
        "Numerous",
        "Nursing",
        "Objective",
        "Obscure",
        "Obvious",
        "Occasional",
        "Occupational",
        "Odd",
        "Offensive",
        "Official",
        "Okay",
        "Old",
        "Old-fashioned",
        "Only",
        "Open",
        "Operational",
        "Opposed",
        "Opposite",
        "Optical",
        "Optimistic",
        "Optional",
        "Oral",
        "Orange",
        "Ordinary",
        "Organic",
        "Organizational",
        "Original",
        "Orthodox",
        "Other",
        "Outdoor",
        "Outer",
        "Outside",
        "Outstanding",
        "Overall",
        "Overseas",
        "Overwhelming",
        "Paid",
        "Painful",
        "Pale",
        "Papal",
        "Parallel",
        "Parental",
        "Parliamentary",
        "Part-time",
        "Partial",
        "Particular",
        "Passionate",
        "Passive",
        "Past",
        "Patient",
        "Payable",
        "Peaceful",
        "Peculiar",
        "Perceived",
        "Perfect",
        "Permanent",
        "Persistent",
        "Personal",
        "Petty",
        "Philosophical",
        "Photographic",
        "Physical",
        "Pink",
        "Plain",
        "Planned",
        "Plausible",
        "Pleasant",
        "Pleased",
        "Polish",
        "Polite",
        "Political",
        "Poor",
        "Popular",
        "Portable",
        "Positive",
        "Possible",
        "Post-war",
        "Potential",
        "Powerful",
        "Practical",
        "Precious",
        "Precise",
        "Predictable",
        "Preferred",
        "Pregnant",
        "Preliminary",
        "Premature",
        "Premier",
        "Present",
        "Presidential",
        "Pretty",
        "Previous",
        "Primary",
        "Prime",
        "Primitive",
        "Principal",
        "Printed",
        "Prior",
        "Private",
        "Privileged",
        "Probable",
        "Productive",
        "Professional",
        "Profitable",
        "Profound",
        "Progressive",
        "Prolonged",
        "Prominent",
        "Prone",
        "Proper",
        "Proportional",
        "Proposed",
        "Prospective",
        "Protective",
        "Proud",
        "Provincial",
        "Provisional",
        "Psychiatric",
        "Psychological",
        "Public",
        "Pure",
        "Purple",
        "Qualified",
        "Quantitative",
        "Quick",
        "Quiet",
        "Racial",
        "Radical",
        "Raised",
        "Random",
        "Rapid",
        "Rare",
        "Rational",
        "Raw",
        "Ready",
        "Real",
        "Realistic",
        "Rear",
        "Reasonable",
        "Recent",
        "Red",
        "Reduced",
        "Redundant",
        "Regional",
        "Regular",
        "Regulatory",
        "Related",
        "Relative",
        "Relevant",
        "Reliable",
        "Religious",
        "Reluctant",
        "Remaining",
        "Remarkable",
        "Remote",
        "Renewed",
        "Repeated",
        "Representative",
        "Required",
        "Resident",
        "Residential",
        "Respectable",
        "Respective",
        "Responsible",
        "Restricted",
        "Restrictive",
        "Resulting",
        "Retail",
        "Retired",
        "Revised",
        "Revolutionary",
        "Rich",
        "Ridiculous",
        "Right",
        "Rigid",
        "Rising",
        "Rival",
        "Romantic",
        "Rotten",
        "Rough",
        "Round",
        "Royal",
        "Rubber",
        "Rude",
        "Ruling",
        "Running",
        "Rural",
        "Sacred",
        "Sad",
        "Safe",
        "Satisfactory",
        "Satisfied",
        "Scared",
        "Scientific",
        "Seasonal",
        "Secondary",
        "Secret",
        "Secular",
        "Secure",
        "Select",
        "Selected",
        "Selective",
        "Semantic",
        "Senior",
        "Sensible",
        "Sensitive",
        "Separate",
        "Serious",
        "Severe",
        "Sensational",
        "Shallow",
        "Shared",
        "Sharp",
        "Sheer",
        "Shocked",
        "Short",
        "Short-term",
        "Shy",
        "Sick",
        "Significant",
        "Silent",
        "Silly",
        "Silver",
        "Similar",
        "Simple",
        "Single",
        "Skilled",
        "Sleeping",
        "Slight",
        "Slim",
        "Slow",
        "Small",
        "Smart",
        "Smooth",
        "So-called",
        "Social",
        "Socialist",
        "Sociological",
        "Soft",
        "Solar",
        "Sole",
        "Solid",
        "Sophisticated",
        "Sore",
        "Sorry",
        "Sound",
        "Southern",
        "Spare",
        "Spatial",
        "Special",
        "Specialist",
        "Specific",
        "Specified",
        "Spectacular",
        "Spiritual",
        "Splendid",
        "Spoken",
        "Spontaneous",
        "Square",
        "Stable",
        "Standard",
        "Static",
        "Statistical",
        "Statutory",
        "Steady",
        "Steep",
        "Sterling",
        "Sticky",
        "Stiff",
        "Still",
        "Stolen",
        "Straight",
        "Straightforward",
        "Strange",
        "Strategic",
        "Strict",
        "Striking",
        "Strong",
        "Structural",
        "Stunning",
        "Stupid",
        "Subject",
        "Subjective",
        "Subsequent",
        "Substantial",
        "Substantive",
        "Subtle",
        "Successful",
        "Successive",
        "Sudden",
        "Sufficient",
        "Suitable",
        "Sunny",
        "Super",
        "Superb",
        "Superior",
        "Supplementary",
        "Supporting",
        "Supposed",
        "Supreme",
        "Sure",
        "Surplus",
        "Surprised",
        "Surprising",
        "Surrounding",
        "Suspicious",
        "Sweet",
        "Swift",
        "Symbolic",
        "Sympathetic",
        "Syntactic",
        "Systematic",
        "Talented",
        "Tall",
        "Technical",
        "Technological",
        "Teenage",
        "Temporary",
        "Tender",
        "Tense",
        "Terminal",
        "Terrible",
        "Territorial",
        "Theoretical",
        "Thick",
        "Thin",
        "Thinking",
        "Thorough",
        "Tight",
        "Tiny",
        "Tired",
        "Top",
        "Total",
        "Tough",
        "Toxic",
        "Trading",
        "Traditional",
        "Tragic",
        "Trained",
        "Tremendous",
        "Trivial",
        "Tropical",
        "True",
        "Typical",
        "Ugly",
        "Ultimate",
        "Unable",
        "Unacceptable",
        "Unaware",
        "Uncertain",
        "Unchanged",
        "Unclear",
        "Uncomfortable",
        "Unconscious",
        "Underground",
        "Underlying",
        "Understandable",
        "Uneasy",
        "Unemployed",
        "Unexpected",
        "Unfair",
        "Unfamiliar",
        "Unfortunate",
        "Unhappy",
        "Uniform",
        "Unique",
        "United",
        "Universal",
        "Unknown",
        "Unlawful",
        "Unlike",
        "Unlikely",
        "Unnecessary",
        "Unpleasant",
        "Unprecedented",
        "Unreasonable",
        "Unsuccessful",
        "Unusual",
        "Unwanted",
        "Unwilling",
        "Up-to-date",
        "Upper",
        "Upset",
        "Urban",
        "Urgent",
        "Used",
        "Useful",
        "Useless",
        "Usual",
        "Vacant",
        "Vague",
        "Valid",
        "Valuable",
        "Variable",
        "Varied",
        "Various",
        "Varying",
        "Vast",
        "Verbal",
        "Vertical",
        "Very",
        "Viable",
        "Vicious",
        "Video-taped",
        "Vigorous",
        "Violent",
        "Virtual",
        "Visible",
        "Visual",
        "Vital",
        "Vivid",
        "Vocational",
        "Voluntary",
        "Vulnerable",
        "Waiting",
        "Walking",
        "Warm",
        "Wary",
        "Waste",
        "Weak",
        "Wealthy",
        "Wee",
        "Weekly",
        "Weird",
        "Welcome",
        "Well",
        "Well-known",
        "Western",
        "Wet",
        "White",
        "Whole",
        "Wicked",
        "Wide",
        "Widespread",
        "Wild",
        "Willing",
        "Winning",
        "Wise",
        "Wonderful",
        "Wooden",
        "Working",
        "Working-class",
        "Worldwide",
        "Worried",
        "Worrying",
        "Worthwhile",
        "Worthy",
        "Written",
        "Wrong",
        "Yellow",
        "Young",
    };

    public static readonly string[] Animals = {
        "Canidae",
        "Felidae",
        "Cat",
        "Cattle",
        "Dog",
        "Donkey",
        "Goat",
        "Guinea pig",
        "Horse",
        "Pig",
        "Rabbit",
        "Fancy rat varieties",
        "Laboratory rat strains",
        "Sheep breeds",
        "Water buffalo breeds",
        "Chicken breeds",
        "Duck breeds",
        "Goose breeds",
        "Pigeon breeds",
        "Turkey breeds",
        "Aardvark",
        "Aardwolf",
        "African buffalo",
        "African elephant",
        "African leopard",
        "Albatross",
        "Alligator",
        "Alpaca",
        "American buffalo (bison)",
        "American robin",
        "Amphibian",
        "List",
        "Anaconda",
        "Angelfish",
        "Anglerfish",
        "Ant",
        "Anteater",
        "Antelope",
        "Antlion",
        "Ape",
        "Aphid",
        "Arabian leopard",
        "Arctic Fox",
        "Arctic Wolf",
        "Armadillo",
        "Arrow crab",
        "Asp",
        "Ass (donkey)",
        "Baboon",
        "Badger",
        "Bald eagle",
        "Bandicoot",
        "Barnacle",
        "Barracuda",
        "Basilisk",
        "Bass",
        "Bat",
        "Beaked whale",
        "Bear",
        "List",
        "Beaver",
        "Bedbug",
        "Bee",
        "Beetle",
        "Bird",
        "List",
        "Bison",
        "Blackbird",
        "Black panther",
        "Black widow spider",
        "Blue bird",
        "Blue jay",
        "Blue whale",
        "Boa",
        "Boar",
        "Bobcat",
        "Bobolink",
        "Bonobo",
        "Booby",
        "Box jellyfish",
        "Bovid",
        "Buffalo, African",
        "Buffalo, American (bison)",
        "Bug",
        "Butterfly",
        "Buzzard",
        "Camel",
        "Canid",
        "Cape buffalo",
        "Capybara",
        "Cardinal",
        "Caribou",
        "Carp",
        "Cat",
        "List",
        "Catshark",
        "Caterpillar",
        "Catfish",
        "Cattle",
        "List",
        "Centipede",
        "Cephalopod",
        "Chameleon",
        "Cheetah",
        "Chickadee",
        "Chicken",
        "List",
        "Chimpanzee",
        "Chinchilla",
        "Chipmunk",
        "Clam",
        "Clownfish",
        "Cobra",
        "Cockroach",
        "Cod",
        "Condor",
        "Constrictor",
        "Coral",
        "Cougar",
        "Cow",
        "Coyote",
        "Crab",
        "Crane",
        "Crane fly",
        "Crawdad",
        "Crayfish",
        "Cricket",
        "Crocodile",
        "Crow",
        "Cuckoo",
        "Cicada",
        "Damselfly",
        "Deer",
        "Dingo",
        "Dinosaur",
        "List",
        "Dog",
        "List",
        "Dolphin",
        "Donkey",
        "List",
        "Dormouse",
        "Dove",
        "Dragonfly",
        "Dragon",
        "Duck",
        "List",
        "Dung beetle",
        "Eagle",
        "Earthworm",
        "Earwig",
        "Echidna",
        "Eel",
        "Egret",
        "Elephant",
        "Elephant seal",
        "Elk",
        "Emu",
        "English pointer",
        "Ermine",
        "Falcon",
        "Ferret",
        "Finch",
        "Firefly",
        "Fish",
        "Flamingo",
        "Flea",
        "Fly",
        "Flyingfish",
        "Fowl",
        "Fox",
        "Frog",
        "Fruit bat",
        "Gamefowl",
        "List",
        "Galliform",
        "List",
        "Gazelle",
        "Gecko",
        "Gerbil",
        "Giant panda",
        "Giant squid",
        "Gibbon",
        "Gila monster",
        "Giraffe",
        "Goat",
        "List",
        "Goldfish",
        "Goose",
        "List",
        "Gopher",
        "Gorilla",
        "Grasshopper",
        "Great blue heron",
        "Great white shark",
        "Grizzly bear",
        "Ground shark",
        "Ground sloth",
        "Grouse",
        "Guan",
        "List",
        "Guanaco",
        "Guineafowl",
        "List",
        "Guinea pig",
        "List",
        "Gull",
        "Guppy",
        "Haddock",
        "Halibut",
        "Hammerhead shark",
        "Hamster",
        "Hare",
        "Harrier",
        "Hawk",
        "Hedgehog",
        "Hermit crab",
        "Heron",
        "Herring",
        "Hippopotamus",
        "Hookworm",
        "Hornet",
        "Horse",
        "List",
        "Hoverfly",
        "Hummingbird",
        "Humpback whale",
        "Hyena",
        "Iguana",
        "Impala",
        "Irukandji jellyfish",
        "Jackal",
        "Jaguar",
        "Jay",
        "Jellyfish",
        "Junglefowl",
        "Kangaroo",
        "Kangaroo mouse",
        "Kangaroo rat",
        "Kingfisher",
        "Kite",
        "Kiwi",
        "Koala",
        "Koi",
        "Komodo dragon",
        "Krill",
        "Ladybug",
        "Lamprey",
        "Landfowl",
        "Land snail",
        "Lark",
        "Leech",
        "Lemming",
        "Lemur",
        "Leopard",
        "Leopon",
        "Limpet",
        "Lion",
        "Lizard",
        "Llama",
        "Lobster",
        "Locust",
        "Loon",
        "Louse",
        "Lungfish",
        "Lynx",
        "Macaw",
        "Mackerel",
        "Magpie",
        "Mammal",
        "Manatee",
        "Mandrill",
        "Manta ray",
        "Marlin",
        "Marmoset",
        "Marmot",
        "Marsupial",
        "Marten",
        "Mastodon",
        "Meadowlark",
        "Meerkat",
        "Mink",
        "Minnow",
        "Mite",
        "Mockingbird",
        "Mole",
        "Mollusk",
        "Mongoose",
        "Monitor lizard",
        "Monkey",
        "Moose",
        "Mosquito",
        "Moth",
        "Mountain goat",
        "Mouse",
        "Mule",
        "Muskox",
        "Narwhal",
        "Newt",
        "New World quail",
        "Nightingale",
        "Ocelot",
        "Octopus",
        "Old World quail",
        "Opossum",
        "Orangutan",
        "Orca",
        "Ostrich",
        "Otter",
        "Owl",
        "Ox",
        "Panda",
        "Panther",
        "Panthera hybrid",
        "Parakeet",
        "Parrot",
        "Parrotfish",
        "Partridge",
        "Peacock",
        "Peafowl",
        "Pelican",
        "Penguin",
        "Perch",
        "Peregrine falcon",
        "Pheasant",
        "Pig",
        "Pigeon",
        "List",
        "Pike",
        "Pilot whale",
        "Pinniped",
        "Piranha",
        "Planarian",
        "Platypus",
        "Polar bear",
        "Pony",
        "Porcupine",
        "Porpoise",
        "Portuguese man o' war",
        "Possum",
        "Prairie dog",
        "Prawn",
        "Praying mantis",
        "Primate",
        "Ptarmigan",
        "Puffin",
        "Puma",
        "Python",
        "Quail",
        "Quelea",
        "Quokka",
        "Rabbit",
        "List",
        "Raccoon",
        "Rainbow trout",
        "Rat",
        "Rattlesnake",
        "Raven",
        "Ray (Batoidea)",
        "Ray (Rajiformes)",
        "Red panda",
        "Reindeer",
        "Reptile",
        "Rhinoceros",
        "Right whale",
        "Roadrunner",
        "Rodent",
        "Rook",
        "Rooster",
        "Roundworm",
        "Saber-toothed cat",
        "Sailfish",
        "Salamander",
        "Salmon",
        "Sawfish",
        "Scale insect",
        "Scallop",
        "Scorpion",
        "Seahorse",
        "Sea lion",
        "Sea slug",
        "Sea snail",
        "Shark",
        "List",
        "Sheep",
        "List",
        "Shrew",
        "Shrimp",
        "Silkworm",
        "Silverfish",
        "Skink",
        "Skunk",
        "Sloth",
        "Slug",
        "Smelt",
        "Snail",
        "Snake",
        "List",
        "Snipe",
        "Snow leopard",
        "Sockeye salmon",
        "Sole",
        "Sparrow",
        "Sperm whale",
        "Spider",
        "Spider monkey",
        "Spoonbill",
        "Squid",
        "Squirrel",
        "Starfish",
        "Star-nosed mole",
        "Steelhead trout",
        "Stingray",
        "Stoat",
        "Stork",
        "Sturgeon",
        "Sugar glider",
        "Swallow",
        "Swan",
        "Swift",
        "Swordfish",
        "Swordtail",
        "Tahr",
        "Takin",
        "Tapir",
        "Tarantula",
        "Tarsier",
        "Tasmanian devil",
        "Termite",
        "Tern",
        "Thrush",
        "Tick",
        "Tiger",
        "Tiger shark",
        "Tiglon",
        "Toad",
        "Tortoise",
        "Toucan",
        "Trapdoor spider",
        "Tree frog",
        "Trout",
        "Tuna",
        "Turkey",
        "List",
        "Turtle",
        "Tyrannosaurus",
        "Urial",
        "Vampire bat",
        "Vampire squid",
        "Vicuna",
        "Viper",
        "Vole",
        "Vulture",
        "Wallaby",
        "Walrus",
        "Wasp",
        "Warbler",
        "Water Boa",
        "Water buffalo",
        "Weasel",
        "Whale",
        "Whippet",
        "Whitefish",
        "Whooping crane",
        "Wildcat",
        "Wildebeest",
        "Wildfowl",
        "Wolf",
        "Wolverine",
        "Wombat",
        "Woodpecker",
        "Worm",
        "Wren",
        "Xerinae",
        "X-ray fish",
        "Yak",
        "Yellow perch",
        "Zebra",
        "Zebra finch",
    };
}
