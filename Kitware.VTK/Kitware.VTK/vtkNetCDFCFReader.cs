using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNetCDFCFReader : vtkNetCDFReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCFReader";

		public new static readonly string MRClassNameKey;

		static vtkNetCDFCFReader()
		{
			vtkNetCDFCFReader.MRClassNameKey = "class vtkNetCDFCFReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFCFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCFReader"));
		}

		public vtkNetCDFCFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFCFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFCFReader New()
		{
			vtkNetCDFCFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNetCDFCFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNetCDFCFReader.vtkNetCDFCFReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFCFReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFCFReader_GetOutputType_02(HandleRef pThis);

		public virtual int GetOutputType()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetOutputType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFCFReader_GetSphericalCoordinates_03(HandleRef pThis);

		public virtual int GetSphericalCoordinates()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetSphericalCoordinates_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkNetCDFCFReader_GetVerticalBias_04(HandleRef pThis);

		public virtual double GetVerticalBias()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetVerticalBias_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkNetCDFCFReader_GetVerticalScale_05(HandleRef pThis);

		public virtual double GetVerticalScale()
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_GetVerticalScale_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFCFReader_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFCFReader_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFCFReader.vtkNetCDFCFReader_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFCFReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNetCDFCFReader NewInstance()
		{
			vtkNetCDFCFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFCFReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFCFReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFCFReader vtkNetCDFCFReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFCFReader.vtkNetCDFCFReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFCFReader = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFCFReader.Register(null);
				}
			}
			return vtkNetCDFCFReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputType_11(HandleRef pThis, int type);

		public virtual void SetOutputType(int type)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputType_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToAutomatic_12(HandleRef pThis);

		public void SetOutputTypeToAutomatic()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToAutomatic_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToImage_13(HandleRef pThis);

		public void SetOutputTypeToImage()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToImage_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToRectilinear_14(HandleRef pThis);

		public void SetOutputTypeToRectilinear()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToRectilinear_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToStructured_15(HandleRef pThis);

		public void SetOutputTypeToStructured()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToStructured_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetOutputTypeToUnstructured_16(HandleRef pThis);

		public void SetOutputTypeToUnstructured()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetOutputTypeToUnstructured_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetSphericalCoordinates_17(HandleRef pThis, int _arg);

		public virtual void SetSphericalCoordinates(int _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetSphericalCoordinates_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetVerticalBias_18(HandleRef pThis, double _arg);

		public virtual void SetVerticalBias(double _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetVerticalBias_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SetVerticalScale_19(HandleRef pThis, double _arg);

		public virtual void SetVerticalScale(double _arg)
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SetVerticalScale_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOff_20(HandleRef pThis);

		public virtual void SphericalCoordinatesOff()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SphericalCoordinatesOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOn_21(HandleRef pThis);

		public virtual void SphericalCoordinatesOn()
		{
			vtkNetCDFCFReader.vtkNetCDFCFReader_SphericalCoordinatesOn_21(base.GetCppThis());
		}
	}
}
