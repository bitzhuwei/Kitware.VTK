using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridToReebGraphFilter : vtkDirectedGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToReebGraphFilter";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridToReebGraphFilter()
		{
			vtkUnstructuredGridToReebGraphFilter.MRClassNameKey = "class vtkUnstructuredGridToReebGraphFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridToReebGraphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToReebGraphFilter"));
		}

		public vtkUnstructuredGridToReebGraphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToReebGraphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridToReebGraphFilter New()
		{
			vtkUnstructuredGridToReebGraphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridToReebGraphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToReebGraphFilter_GetFieldId_01(HandleRef pThis);

		public virtual int GetFieldId()
		{
			return vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_GetFieldId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToReebGraphFilter_GetOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraph GetOutput()
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_GetOutput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkUnstructuredGridToReebGraphFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToReebGraphFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToReebGraphFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridToReebGraphFilter NewInstance()
		{
			vtkUnstructuredGridToReebGraphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToReebGraphFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridToReebGraphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridToReebGraphFilter vtkUnstructuredGridToReebGraphFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridToReebGraphFilter = (vtkUnstructuredGridToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridToReebGraphFilter.Register(null);
				}
			}
			return vtkUnstructuredGridToReebGraphFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridToReebGraphFilter_SetFieldId_08(HandleRef pThis, int _arg);

		public virtual void SetFieldId(int _arg)
		{
			vtkUnstructuredGridToReebGraphFilter.vtkUnstructuredGridToReebGraphFilter_SetFieldId_08(base.GetCppThis(), _arg);
		}
	}
}
