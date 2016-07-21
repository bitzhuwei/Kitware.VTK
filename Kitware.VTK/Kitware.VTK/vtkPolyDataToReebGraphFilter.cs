using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataToReebGraphFilter : vtkDirectedGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToReebGraphFilter";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataToReebGraphFilter()
		{
			vtkPolyDataToReebGraphFilter.MRClassNameKey = "class vtkPolyDataToReebGraphFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToReebGraphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToReebGraphFilter"));
		}

		public vtkPolyDataToReebGraphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataToReebGraphFilter New()
		{
			vtkPolyDataToReebGraphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataToReebGraphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataToReebGraphFilter_GetFieldId_01(HandleRef pThis);

		public virtual int GetFieldId()
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetFieldId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_GetOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraph GetOutput()
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetOutput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraph = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraph.Register(null);
				}
			}
			return vtkReebGraph;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataToReebGraphFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataToReebGraphFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataToReebGraphFilter NewInstance()
		{
			vtkPolyDataToReebGraphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataToReebGraphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToReebGraphFilter vtkPolyDataToReebGraphFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToReebGraphFilter = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToReebGraphFilter.Register(null);
				}
			}
			return vtkPolyDataToReebGraphFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataToReebGraphFilter_SetFieldId_08(HandleRef pThis, int _arg);

		public virtual void SetFieldId(int _arg)
		{
			vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_SetFieldId_08(base.GetCppThis(), _arg);
		}
	}
}
