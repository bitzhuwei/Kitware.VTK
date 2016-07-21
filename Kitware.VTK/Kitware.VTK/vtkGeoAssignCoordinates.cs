using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoAssignCoordinates : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoAssignCoordinates";

		public new static readonly string MRClassNameKey;

		static vtkGeoAssignCoordinates()
		{
			vtkGeoAssignCoordinates.MRClassNameKey = "class vtkGeoAssignCoordinates";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoAssignCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoAssignCoordinates"));
		}

		public vtkGeoAssignCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAssignCoordinates New()
		{
			vtkGeoAssignCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoAssignCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_CoordinatesInArraysOff_01(HandleRef pThis);

		public virtual void CoordinatesInArraysOff()
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_CoordinatesInArraysOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_CoordinatesInArraysOn_02(HandleRef pThis);

		public virtual void CoordinatesInArraysOn()
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_CoordinatesInArraysOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoAssignCoordinates_GetCoordinatesInArrays_03(HandleRef pThis);

		public virtual bool GetCoordinatesInArrays()
		{
			return vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_GetCoordinatesInArrays_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAssignCoordinates_GetGlobeRadius_04(HandleRef pThis);

		public virtual double GetGlobeRadius()
		{
			return vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_GetGlobeRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_GetLatitudeArrayName_05(HandleRef pThis);

		public virtual string GetLatitudeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_GetLatitudeArrayName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_GetLongitudeArrayName_06(HandleRef pThis);

		public virtual string GetLongitudeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_GetLongitudeArrayName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_GetTransform_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_GetTransform_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAssignCoordinates_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAssignCoordinates_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoAssignCoordinates NewInstance()
		{
			vtkGeoAssignCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAssignCoordinates_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAssignCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkGeoAssignCoordinates vtkGeoAssignCoordinates = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoAssignCoordinates = (vtkGeoAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoAssignCoordinates.Register(null);
				}
			}
			return vtkGeoAssignCoordinates;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_SetCoordinatesInArrays_13(HandleRef pThis, byte _arg);

		public virtual void SetCoordinatesInArrays(bool _arg)
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SetCoordinatesInArrays_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_SetGlobeRadius_14(HandleRef pThis, double _arg);

		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SetGlobeRadius_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_SetLatitudeArrayName_15(HandleRef pThis, string _arg);

		public virtual void SetLatitudeArrayName(string _arg)
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SetLatitudeArrayName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_SetLongitudeArrayName_16(HandleRef pThis, string _arg);

		public virtual void SetLongitudeArrayName(string _arg)
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SetLongitudeArrayName_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAssignCoordinates_SetTransform_17(HandleRef pThis, HandleRef trans);

		public virtual void SetTransform(vtkAbstractTransform trans)
		{
			vtkGeoAssignCoordinates.vtkGeoAssignCoordinates_SetTransform_17(base.GetCppThis(), (trans == null) ? default(HandleRef) : trans.GetCppThis());
		}
	}
}
