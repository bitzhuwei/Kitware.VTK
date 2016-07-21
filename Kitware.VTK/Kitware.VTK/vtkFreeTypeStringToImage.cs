using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFreeTypeStringToImage : vtkStringToImage
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeStringToImage";

		public new static readonly string MRClassNameKey;

		static vtkFreeTypeStringToImage()
		{
			vtkFreeTypeStringToImage.MRClassNameKey = "class vtkFreeTypeStringToImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFreeTypeStringToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeStringToImage"));
		}

		public vtkFreeTypeStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeStringToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFreeTypeStringToImage New()
		{
			vtkFreeTypeStringToImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFreeTypeStringToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFreeTypeStringToImage_DeepCopy_01(HandleRef pThis, HandleRef utility);

		public void DeepCopy(vtkFreeTypeStringToImage utility)
		{
			vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_DeepCopy_01(base.GetCppThis(), (utility == null) ? default(HandleRef) : utility.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFreeTypeStringToImage_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFreeTypeStringToImage_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeStringToImage_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFreeTypeStringToImage NewInstance()
		{
			vtkFreeTypeStringToImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeStringToImage_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFreeTypeStringToImage SafeDownCast(vtkObjectBase o)
		{
			vtkFreeTypeStringToImage vtkFreeTypeStringToImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeStringToImage = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeStringToImage.Register(null);
				}
			}
			return vtkFreeTypeStringToImage;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFreeTypeStringToImage_SetScaleToPowerOfTwo_07(HandleRef pThis, byte scale);

		public override void SetScaleToPowerOfTwo(bool scale)
		{
			vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_SetScaleToPowerOfTwo_07(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}
	}
}
