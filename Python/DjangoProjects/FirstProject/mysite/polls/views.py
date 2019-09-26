from django.http import HttpResponse
from django.shortcuts import render, get_object_or_404

# Create your views here.
from .models import Question


def index(request):
    question_list = Question.objects.order_by('pub_date')

    '''output = ", ".join(q.question_text for q in question_list)
    return HttpResponse(output)'''

    context = {'question_list': question_list}  # Creating a dictionary.
    return render(request, 'polls/index.html', context)


def detail(request, question_id):

    # Simple HttpResponse
    '''return HttpResponse('This is the detail view of the question: %s' % question_id)'''

    # Querying the question id against the Question collection
    '''question = Question.objects.get(pk = question_id)'''

    # Tries to query the question from the Question collection, if not shows up 404 - Page not found error
    question = get_object_or_404(Question, pk = question_id)

    return render(request, 'polls/detail.html', {'question' : question})


def results(request, question_id):
    return HttpResponse('This is the results view of the question: %s' % question_id)


def vote(request, question_id):
    return HttpResponse('This is the vote view of the question: %s' % question_id)
