export interface FormFeaturesModel {
    questions: Question[];
    id:        string;
}

export interface Question {
    name:     string;
    answerId: string;
    options:  Option[];
    id:       string;
}

export interface Option {
    name: string;
    id:   string;
}