import { IProfileDto } from '../profile';
import { IQuestResponseDto } from '../quest-response';
import { IQuestTaskDto } from '../quest-task';

interface IQuestDto {
    id: string;
    authorId?: string;
    author?: IProfileDto;
    title: string;
    description: string;
    createdAt: string;
    updatedAt: string;
    tasks: IQuestTaskDto[];
    questResponses: IQuestResponseDto[];
    xpForComplete: number;
    xpForSuccess: number;
    status: string;
    timeLimitInSeconds?: number;
    url?: string;
    numberOfTasks: number;
}

export { type IQuestDto };
