using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeGraphs : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeGraphs";

		public new static readonly string MRClassNameKey;

		static vtkMergeGraphs()
		{
			vtkMergeGraphs.MRClassNameKey = "class vtkMergeGraphs";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeGraphs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeGraphs"));
		}

		public vtkMergeGraphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeGraphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeGraphs New()
		{
			vtkMergeGraphs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeGraphs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeGraphs.vtkMergeGraphs_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeGraphs_ExtendGraph_01(HandleRef pThis, HandleRef g1, HandleRef g2);

		public int ExtendGraph(vtkMutableGraphHelper g1, vtkGraph g2)
		{
			return vtkMergeGraphs.vtkMergeGraphs_ExtendGraph_01(base.GetCppThis(), (g1 == null) ? default(HandleRef) : g1.GetCppThis(), (g2 == null) ? default(HandleRef) : g2.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkMergeGraphs_GetEdgeWindow_02(HandleRef pThis);

		public virtual double GetEdgeWindow()
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetEdgeWindow_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeGraphs_GetEdgeWindowArrayName_03(HandleRef pThis);

		public virtual string GetEdgeWindowArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkMergeGraphs.vtkMergeGraphs_GetEdgeWindowArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkMergeGraphs_GetUseEdgeWindow_04(HandleRef pThis);

		public virtual bool GetUseEdgeWindow()
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetUseEdgeWindow_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeGraphs_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeGraphs_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeGraphs_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeGraphs NewInstance()
		{
			vtkMergeGraphs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeGraphs_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeGraphs SafeDownCast(vtkObjectBase o)
		{
			vtkMergeGraphs vtkMergeGraphs = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeGraphs = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeGraphs.Register(null);
				}
			}
			return vtkMergeGraphs;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeGraphs_SetEdgeWindow_10(HandleRef pThis, double _arg);

		public virtual void SetEdgeWindow(double _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetEdgeWindow_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeGraphs_SetEdgeWindowArrayName_11(HandleRef pThis, string _arg);

		public virtual void SetEdgeWindowArrayName(string _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetEdgeWindowArrayName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeGraphs_SetUseEdgeWindow_12(HandleRef pThis, byte _arg);

		public virtual void SetUseEdgeWindow(bool _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetUseEdgeWindow_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeGraphs_UseEdgeWindowOff_13(HandleRef pThis);

		public virtual void UseEdgeWindowOff()
		{
			vtkMergeGraphs.vtkMergeGraphs_UseEdgeWindowOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeGraphs_UseEdgeWindowOn_14(HandleRef pThis);

		public virtual void UseEdgeWindowOn()
		{
			vtkMergeGraphs.vtkMergeGraphs_UseEdgeWindowOn_14(base.GetCppThis());
		}
	}
}
