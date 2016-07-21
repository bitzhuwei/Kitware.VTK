using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThresholdGraph : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdGraph";

		public new static readonly string MRClassNameKey;

		static vtkThresholdGraph()
		{
			vtkThresholdGraph.MRClassNameKey = "class vtkThresholdGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdGraph"));
		}

		public vtkThresholdGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdGraph New()
		{
			vtkThresholdGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThresholdGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThresholdGraph.vtkThresholdGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkThresholdGraph_GetLowerThreshold_01(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetLowerThreshold_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkThresholdGraph_GetUpperThreshold_02(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetUpperThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdGraph_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdGraph_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdGraph_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThresholdGraph NewInstance()
		{
			vtkThresholdGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdGraph_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdGraph SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdGraph vtkThresholdGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdGraph = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdGraph.Register(null);
				}
			}
			return vtkThresholdGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdGraph_SetLowerThreshold_08(HandleRef pThis, double _arg);

		public virtual void SetLowerThreshold(double _arg)
		{
			vtkThresholdGraph.vtkThresholdGraph_SetLowerThreshold_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdGraph_SetUpperThreshold_09(HandleRef pThis, double _arg);

		public virtual void SetUpperThreshold(double _arg)
		{
			vtkThresholdGraph.vtkThresholdGraph_SetUpperThreshold_09(base.GetCppThis(), _arg);
		}
	}
}
