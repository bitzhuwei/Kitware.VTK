using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutlineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineFilter";

		public new static readonly string MRClassNameKey;

		static vtkOutlineFilter()
		{
			vtkOutlineFilter.MRClassNameKey = "class vtkOutlineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineFilter"));
		}

		public vtkOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineFilter New()
		{
			vtkOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutlineFilter.vtkOutlineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineFilter_GenerateFacesOff_01(HandleRef pThis);

		public virtual void GenerateFacesOff()
		{
			vtkOutlineFilter.vtkOutlineFilter_GenerateFacesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineFilter_GenerateFacesOn_02(HandleRef pThis);

		public virtual void GenerateFacesOn()
		{
			vtkOutlineFilter.vtkOutlineFilter_GenerateFacesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineFilter_GetGenerateFaces_03(HandleRef pThis);

		public virtual int GetGenerateFaces()
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetGenerateFaces_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutlineFilter NewInstance()
		{
			vtkOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineFilter vtkOutlineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineFilter = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineFilter.Register(null);
				}
			}
			return vtkOutlineFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineFilter_SetGenerateFaces_09(HandleRef pThis, int _arg);

		public virtual void SetGenerateFaces(int _arg)
		{
			vtkOutlineFilter.vtkOutlineFilter_SetGenerateFaces_09(base.GetCppThis(), _arg);
		}
	}
}
