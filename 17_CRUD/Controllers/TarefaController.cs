using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
public class TarefaController : Controller
{
    private static List<Tarefa> _tarefas = new List<Tarefa>();
    public IActionResult Index()
    {
        return View(_tarefas);
    }
    public IActionResult Adicionar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Adicionar(Tarefa tarefa)
    {
        tarefa.Id = _tarefas.Count + 1;
        _tarefas.Add(tarefa);
        return RedirectToAction("Index");
    }
    public IActionResult Editar(int id)
    {
        Tarefa tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
        {
            return NotFound();
        }
        return View(tarefa);
    }
    [HttpPost]
    public IActionResult Editar(Tarefa tarefa)
    {
        Tarefa existingTarefa = _tarefas.FirstOrDefault(t => t.Id == tarefa.Id);
        if (existingTarefa == null)
        {
            return NotFound();
        }
        existingTarefa.Descricao = tarefa.Descricao;
        existingTarefa.Concluida = tarefa.Concluida;
        return RedirectToAction("Index");
    }
    public IActionResult Deletar(int id)
    {
        Tarefa tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
        {
            return NotFound();
        }
        return View(tarefa);
    }
    [HttpPost]
    public IActionResult DeletarConfirmado(int id)
    {
        Tarefa tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
        {
            return NotFound();
        }
        _tarefas.Remove(tarefa);
        return RedirectToAction("Index");
    }
}
