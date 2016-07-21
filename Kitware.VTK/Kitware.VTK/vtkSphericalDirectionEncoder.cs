using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphericalDirectionEncoder : vtkDirectionEncoder
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalDirectionEncoder";

		public new static readonly string MRClassNameKey;

		static vtkSphericalDirectionEncoder()
		{
			vtkSphericalDirectionEncoder.MRClassNameKey = "class vtkSphericalDirectionEncoder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphericalDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalDirectionEncoder"));
		}

		public vtkSphericalDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphericalDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphericalDirectionEncoder New()
		{
			vtkSphericalDirectionEncoder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphericalDirectionEncoder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		public override float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		public override IntPtr GetDecodedGradientTable()
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSphericalDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		public override int GetEncodedDirection(IntPtr n)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		public override int GetNumberOfEncodedDirections()
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSphericalDirectionEncoder_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSphericalDirectionEncoder_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphericalDirectionEncoder_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphericalDirectionEncoder NewInstance()
		{
			vtkSphericalDirectionEncoder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphericalDirectionEncoder_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphericalDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkSphericalDirectionEncoder vtkSphericalDirectionEncoder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphericalDirectionEncoder.vtkSphericalDirectionEncoder_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphericalDirectionEncoder = (vtkSphericalDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphericalDirectionEncoder.Register(null);
				}
			}
			return vtkSphericalDirectionEncoder;
		}
	}
}
