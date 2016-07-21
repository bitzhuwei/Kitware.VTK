using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMassProperties : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMassProperties";

		public new static readonly string MRClassNameKey;

		static vtkMassProperties()
		{
			vtkMassProperties.MRClassNameKey = "class vtkMassProperties";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMassProperties.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMassProperties"));
		}

		public vtkMassProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMassProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMassProperties New()
		{
			vtkMassProperties result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMassProperties() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMassProperties.vtkMassProperties_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetKx_01(HandleRef pThis);

		public double GetKx()
		{
			return vtkMassProperties.vtkMassProperties_GetKx_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetKy_02(HandleRef pThis);

		public double GetKy()
		{
			return vtkMassProperties.vtkMassProperties_GetKy_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetKz_03(HandleRef pThis);

		public double GetKz()
		{
			return vtkMassProperties.vtkMassProperties_GetKz_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetMaxCellArea_04(HandleRef pThis);

		public double GetMaxCellArea()
		{
			return vtkMassProperties.vtkMassProperties_GetMaxCellArea_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetMinCellArea_05(HandleRef pThis);

		public double GetMinCellArea()
		{
			return vtkMassProperties.vtkMassProperties_GetMinCellArea_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetNormalizedShapeIndex_06(HandleRef pThis);

		public double GetNormalizedShapeIndex()
		{
			return vtkMassProperties.vtkMassProperties_GetNormalizedShapeIndex_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetSurfaceArea_07(HandleRef pThis);

		public double GetSurfaceArea()
		{
			return vtkMassProperties.vtkMassProperties_GetSurfaceArea_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetVolume_08(HandleRef pThis);

		public double GetVolume()
		{
			return vtkMassProperties.vtkMassProperties_GetVolume_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetVolumeProjected_09(HandleRef pThis);

		public double GetVolumeProjected()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeProjected_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetVolumeX_10(HandleRef pThis);

		public double GetVolumeX()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeX_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetVolumeY_11(HandleRef pThis);

		public double GetVolumeY()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeY_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMassProperties_GetVolumeZ_12(HandleRef pThis);

		public double GetVolumeZ()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeZ_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMassProperties_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMassProperties.vtkMassProperties_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMassProperties_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMassProperties.vtkMassProperties_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMassProperties_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMassProperties NewInstance()
		{
			vtkMassProperties result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMassProperties_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMassProperties SafeDownCast(vtkObjectBase o)
		{
			vtkMassProperties vtkMassProperties = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMassProperties = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMassProperties.Register(null);
				}
			}
			return vtkMassProperties;
		}
	}
}
