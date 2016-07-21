using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTriangleFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleFilter";

		public new static readonly string MRClassNameKey;

		static vtkTriangleFilter()
		{
			vtkTriangleFilter.MRClassNameKey = "class vtkTriangleFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleFilter"));
		}

		public vtkTriangleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangleFilter New()
		{
			vtkTriangleFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTriangleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTriangleFilter.vtkTriangleFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangleFilter_GetPassLines_01(HandleRef pThis);

		public virtual int GetPassLines()
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetPassLines_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangleFilter_GetPassVerts_02(HandleRef pThis);

		public virtual int GetPassVerts()
		{
			return vtkTriangleFilter.vtkTriangleFilter_GetPassVerts_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangleFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangleFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTriangleFilter.vtkTriangleFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangleFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTriangleFilter NewInstance()
		{
			vtkTriangleFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_PassLinesOff_07(HandleRef pThis);

		public virtual void PassLinesOff()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassLinesOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_PassLinesOn_08(HandleRef pThis);

		public virtual void PassLinesOn()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassLinesOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_PassVertsOff_09(HandleRef pThis);

		public virtual void PassVertsOff()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassVertsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_PassVertsOn_10(HandleRef pThis);

		public virtual void PassVertsOn()
		{
			vtkTriangleFilter.vtkTriangleFilter_PassVertsOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangleFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTriangleFilter vtkTriangleFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangleFilter.vtkTriangleFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangleFilter = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangleFilter.Register(null);
				}
			}
			return vtkTriangleFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_SetPassLines_12(HandleRef pThis, int _arg);

		public virtual void SetPassLines(int _arg)
		{
			vtkTriangleFilter.vtkTriangleFilter_SetPassLines_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTriangleFilter_SetPassVerts_13(HandleRef pThis, int _arg);

		public virtual void SetPassVerts(int _arg)
		{
			vtkTriangleFilter.vtkTriangleFilter_SetPassVerts_13(base.GetCppThis(), _arg);
		}
	}
}
