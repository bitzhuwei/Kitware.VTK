using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoSphereTransform : vtkAbstractTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoSphereTransform";

		public new static readonly string MRClassNameKey;

		static vtkGeoSphereTransform()
		{
			vtkGeoSphereTransform.MRClassNameKey = "class vtkGeoSphereTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoSphereTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoSphereTransform"));
		}

		public vtkGeoSphereTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSphereTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoSphereTransform New()
		{
			vtkGeoSphereTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSphereTransform.vtkGeoSphereTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoSphereTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoSphereTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoSphereTransform.vtkGeoSphereTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoSphereTransform_GetBaseAltitude_01(HandleRef pThis);

		public virtual double GetBaseAltitude()
		{
			return vtkGeoSphereTransform.vtkGeoSphereTransform_GetBaseAltitude_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoSphereTransform_GetToRectangular_02(HandleRef pThis);

		public virtual bool GetToRectangular()
		{
			return vtkGeoSphereTransform.vtkGeoSphereTransform_GetToRectangular_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_InternalTransformPoint_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_InternalTransformPoint_03(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_Inverse_04(HandleRef pThis);

		public override void Inverse()
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_Inverse_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSphereTransform_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoSphereTransform.vtkGeoSphereTransform_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSphereTransform_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoSphereTransform.vtkGeoSphereTransform_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSphereTransform_MakeTransform_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSphereTransform.vtkGeoSphereTransform_MakeTransform_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSphereTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoSphereTransform NewInstance()
		{
			vtkGeoSphereTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSphereTransform.vtkGeoSphereTransform_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoSphereTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSphereTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoSphereTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGeoSphereTransform vtkGeoSphereTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSphereTransform.vtkGeoSphereTransform_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoSphereTransform = (vtkGeoSphereTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoSphereTransform.Register(null);
				}
			}
			return vtkGeoSphereTransform;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_SetBaseAltitude_11(HandleRef pThis, double _arg);

		public virtual void SetBaseAltitude(double _arg)
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_SetBaseAltitude_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_SetToRectangular_12(HandleRef pThis, byte _arg);

		public virtual void SetToRectangular(bool _arg)
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_SetToRectangular_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_ToRectangularOff_13(HandleRef pThis);

		public virtual void ToRectangularOff()
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_ToRectangularOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSphereTransform_ToRectangularOn_14(HandleRef pThis);

		public virtual void ToRectangularOn()
		{
			vtkGeoSphereTransform.vtkGeoSphereTransform_ToRectangularOn_14(base.GetCppThis());
		}
	}
}
