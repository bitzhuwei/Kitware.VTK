using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamGraph : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamGraph";

		public new static readonly string MRClassNameKey;

		static vtkStreamGraph()
		{
			vtkStreamGraph.MRClassNameKey = "class vtkStreamGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamGraph"));
		}

		public vtkStreamGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamGraph New()
		{
			vtkStreamGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamGraph.vtkStreamGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkStreamGraph_GetEdgeWindow_01(HandleRef pThis);

		public virtual double GetEdgeWindow()
		{
			return vtkStreamGraph.vtkStreamGraph_GetEdgeWindow_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamGraph_GetEdgeWindowArrayName_02(HandleRef pThis);

		public virtual string GetEdgeWindowArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkStreamGraph.vtkStreamGraph_GetEdgeWindowArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStreamGraph_GetUseEdgeWindow_03(HandleRef pThis);

		public virtual bool GetUseEdgeWindow()
		{
			return vtkStreamGraph.vtkStreamGraph_GetUseEdgeWindow_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStreamGraph_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStreamGraph_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamGraph_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamGraph NewInstance()
		{
			vtkStreamGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamGraph_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamGraph SafeDownCast(vtkObjectBase o)
		{
			vtkStreamGraph vtkStreamGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamGraph = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamGraph.Register(null);
				}
			}
			return vtkStreamGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamGraph_SetEdgeWindow_09(HandleRef pThis, double _arg);

		public virtual void SetEdgeWindow(double _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetEdgeWindow_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamGraph_SetEdgeWindowArrayName_10(HandleRef pThis, string _arg);

		public virtual void SetEdgeWindowArrayName(string _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetEdgeWindowArrayName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamGraph_SetUseEdgeWindow_11(HandleRef pThis, byte _arg);

		public virtual void SetUseEdgeWindow(bool _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetUseEdgeWindow_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamGraph_UseEdgeWindowOff_12(HandleRef pThis);

		public virtual void UseEdgeWindowOff()
		{
			vtkStreamGraph.vtkStreamGraph_UseEdgeWindowOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamGraph_UseEdgeWindowOn_13(HandleRef pThis);

		public virtual void UseEdgeWindowOn()
		{
			vtkStreamGraph.vtkStreamGraph_UseEdgeWindowOn_13(base.GetCppThis());
		}
	}
}
