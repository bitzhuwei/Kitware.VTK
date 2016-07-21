using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBlankStructuredGridWithImage : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlankStructuredGridWithImage";

		public new static readonly string MRClassNameKey;

		static vtkBlankStructuredGridWithImage()
		{
			vtkBlankStructuredGridWithImage.MRClassNameKey = "class vtkBlankStructuredGridWithImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlankStructuredGridWithImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlankStructuredGridWithImage"));
		}

		public vtkBlankStructuredGridWithImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlankStructuredGridWithImage New()
		{
			vtkBlankStructuredGridWithImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBlankStructuredGridWithImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_GetBlankingInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetBlankingInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_GetBlankingInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGridWithImage_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGridWithImage_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBlankStructuredGridWithImage NewInstance()
		{
			vtkBlankStructuredGridWithImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlankStructuredGridWithImage SafeDownCast(vtkObjectBase o)
		{
			vtkBlankStructuredGridWithImage vtkBlankStructuredGridWithImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlankStructuredGridWithImage = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlankStructuredGridWithImage.Register(null);
				}
			}
			return vtkBlankStructuredGridWithImage;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGridWithImage_SetBlankingInput_07(HandleRef pThis, HandleRef input);

		public void SetBlankingInput(vtkImageData input)
		{
			vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_SetBlankingInput_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
