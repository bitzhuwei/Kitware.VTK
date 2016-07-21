using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformPolyDataFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkTransformPolyDataFilter()
		{
			vtkTransformPolyDataFilter.MRClassNameKey = "class vtkTransformPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformPolyDataFilter"));
		}

		public vtkTransformPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformPolyDataFilter New()
		{
			vtkTransformPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkTransformPolyDataFilter_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformPolyDataFilter_GetTransform_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_GetTransform_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformPolyDataFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformPolyDataFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformPolyDataFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformPolyDataFilter NewInstance()
		{
			vtkTransformPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformPolyDataFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTransformPolyDataFilter vtkTransformPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformPolyDataFilter = (vtkTransformPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformPolyDataFilter.Register(null);
				}
			}
			return vtkTransformPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformPolyDataFilter_SetTransform_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkTransformPolyDataFilter.vtkTransformPolyDataFilter_SetTransform_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
