import { Paragraph } from './paragraph.model';
import { Question } from 'src/app/model/question.model';
export interface GroupQuestion {
    id: number;
    questions: Question[],
    fileAudios: any[],
    paragraphs: Paragraph[],
    examId: number,
}

export interface ListQuestionResolved {
    listQuestions: GroupQuestion[];
    error?: any;
}