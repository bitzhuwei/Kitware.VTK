using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTIFFReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFReader";

		public new static readonly string MRClassNameKey;

		static vtkTIFFReader()
		{
			vtkTIFFReader.MRClassNameKey = "class vtkTIFFReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTIFFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFReader"));
		}

		public vtkTIFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTIFFReader New()
		{
			vtkTIFFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTIFFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTIFFReader.vtkTIFFReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFReader_CanReadFile_01(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkTIFFReader.vtkTIFFReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFReader_GetDescriptiveName_02(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkTIFFReader.vtkTIFFReader_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFReader_GetFileExtensions_03(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkTIFFReader.vtkTIFFReader_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkTIFFReader_GetOrientationType_04(HandleRef pThis);

		public virtual uint GetOrientationType()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOrientationType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTIFFReader_GetOrientationTypeSpecifiedFlag_05(HandleRef pThis);

		public virtual bool GetOrientationTypeSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOrientationTypeSpecifiedFlag_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTIFFReader_GetOriginSpecifiedFlag_06(HandleRef pThis);

		public virtual bool GetOriginSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetOriginSpecifiedFlag_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTIFFReader_GetSpacingSpecifiedFlag_07(HandleRef pThis);

		public virtual bool GetSpacingSpecifiedFlag()
		{
			return vtkTIFFReader.vtkTIFFReader_GetSpacingSpecifiedFlag_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_InitializeColors_08(HandleRef pThis);

		public void InitializeColors()
		{
			vtkTIFFReader.vtkTIFFReader_InitializeColors_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFReader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFReader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTIFFReader.vtkTIFFReader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTIFFReader NewInstance()
		{
			vtkTIFFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_OriginSpecifiedFlagOff_13(HandleRef pThis);

		public virtual void OriginSpecifiedFlagOff()
		{
			vtkTIFFReader.vtkTIFFReader_OriginSpecifiedFlagOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_OriginSpecifiedFlagOn_14(HandleRef pThis);

		public virtual void OriginSpecifiedFlagOn()
		{
			vtkTIFFReader.vtkTIFFReader_OriginSpecifiedFlagOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_ReadImageInternal_15(HandleRef pThis, IntPtr arg0, IntPtr outPtr, IntPtr outExt, uint size);

		public void ReadImageInternal(IntPtr arg0, IntPtr outPtr, IntPtr outExt, uint size)
		{
			vtkTIFFReader.vtkTIFFReader_ReadImageInternal_15(base.GetCppThis(), arg0, outPtr, outExt, size);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_ReadTiles_16(HandleRef pThis, IntPtr buffer);

		public virtual void ReadTiles(IntPtr buffer)
		{
			vtkTIFFReader.vtkTIFFReader_ReadTiles_16(base.GetCppThis(), buffer);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_ReadVolume_17(HandleRef pThis, IntPtr buffer);

		public virtual void ReadVolume(IntPtr buffer)
		{
			vtkTIFFReader.vtkTIFFReader_ReadVolume_17(base.GetCppThis(), buffer);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTIFFReader SafeDownCast(vtkObjectBase o)
		{
			vtkTIFFReader vtkTIFFReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFReader.vtkTIFFReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTIFFReader = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTIFFReader.Register(null);
				}
			}
			return vtkTIFFReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_SetOrientationType_19(HandleRef pThis, uint orientationType);

		public void SetOrientationType(uint orientationType)
		{
			vtkTIFFReader.vtkTIFFReader_SetOrientationType_19(base.GetCppThis(), orientationType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_SetOriginSpecifiedFlag_20(HandleRef pThis, byte _arg);

		public virtual void SetOriginSpecifiedFlag(bool _arg)
		{
			vtkTIFFReader.vtkTIFFReader_SetOriginSpecifiedFlag_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_SetSpacingSpecifiedFlag_21(HandleRef pThis, byte _arg);

		public virtual void SetSpacingSpecifiedFlag(bool _arg)
		{
			vtkTIFFReader.vtkTIFFReader_SetSpacingSpecifiedFlag_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOff_22(HandleRef pThis);

		public virtual void SpacingSpecifiedFlagOff()
		{
			vtkTIFFReader.vtkTIFFReader_SpacingSpecifiedFlagOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOn_23(HandleRef pThis);

		public virtual void SpacingSpecifiedFlagOn()
		{
			vtkTIFFReader.vtkTIFFReader_SpacingSpecifiedFlagOn_23(base.GetCppThis());
		}
	}
}
