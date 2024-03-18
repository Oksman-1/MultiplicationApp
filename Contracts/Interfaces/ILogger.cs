using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces;

public interface ILogger
{
	void Info(string logText);	
	void Warn(string logText);
	void Error(string logText);
	void WriteLog(string strLog);
}
