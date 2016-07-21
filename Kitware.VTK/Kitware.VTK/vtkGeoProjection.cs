using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoProjection : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoProjection";

		public new static readonly string MRClassNameKey;

		static vtkGeoProjection()
		{
			vtkGeoProjection.MRClassNameKey = "class vtkGeoProjection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoProjection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoProjection"));
		}

		public vtkGeoProjection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoProjection New()
		{
			vtkGeoProjection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoProjection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoProjection.vtkGeoProjection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoProjection_GetCentralMeridian_01(HandleRef pThis);

		public virtual double GetCentralMeridian()
		{
			return vtkGeoProjection.vtkGeoProjection_GetCentralMeridian_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_GetDescription_02(HandleRef pThis);

		public string GetDescription()
		{
			return Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetDescription_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjection_GetIndex_03(HandleRef pThis);

		public int GetIndex()
		{
			return vtkGeoProjection.vtkGeoProjection_GetIndex_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_GetName_04(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjection_GetNumberOfProjections_05();

		public static int GetNumberOfProjections()
		{
			return vtkGeoProjection.vtkGeoProjection_GetNumberOfProjections_05();
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_GetProjectionDescription_06(int projection);

		public static string GetProjectionDescription(int projection)
		{
			return Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetProjectionDescription_06(projection));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_GetProjectionName_07(int projection);

		public static string GetProjectionName(int projection)
		{
			return Marshal.PtrToStringAnsi(vtkGeoProjection.vtkGeoProjection_GetProjectionName_07(projection));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjection_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjection_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoProjection.vtkGeoProjection_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoProjection NewInstance()
		{
			vtkGeoProjection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjection_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoProjection SafeDownCast(vtkObjectBase o)
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjection.vtkGeoProjection_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoProjection = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoProjection.Register(null);
				}
			}
			return vtkGeoProjection;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoProjection_SetCentralMeridian_13(HandleRef pThis, double _arg);

		public virtual void SetCentralMeridian(double _arg)
		{
			vtkGeoProjection.vtkGeoProjection_SetCentralMeridian_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoProjection_SetName_14(HandleRef pThis, string _arg);

		public virtual void SetName(string _arg)
		{
			vtkGeoProjection.vtkGeoProjection_SetName_14(base.GetCppThis(), _arg);
		}
	}
}
